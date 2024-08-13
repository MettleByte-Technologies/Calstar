using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CalStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputFile.Text))
            {
                MessageBox.Show("Please select a Calstar CSV file.");
                return;
            }

            string tempDirectory = Path.GetTempPath();
            string tempFileName = Path.GetFileNameWithoutExtension(txtInputFile.Text) + "_converted.csv";
            string cornerstoneFilePath = Path.Combine(tempDirectory, tempFileName);

            try
            {
                var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                    HeaderValidated = null,
                    MissingFieldFound = null
                };

                using (var reader = new FileStream(txtInputFile.Text, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var calStarCsvReader = new CsvReader(new StreamReader(reader), csvConfig))
                {
                    //Read csv file
                    calStarCsvReader.Context.RegisterClassMap<CalStarMap>();
                    var calStarRecords = calStarCsvReader.GetRecords<CalStar>().ToList();

                    // Debug: Check if records are being read
                    if (!calStarRecords.Any())
                    {
                        MessageBox.Show("No records found in the input file.");
                        return;
                    }

                    // Convert Calstart to cornerstone.
                    var cornerstoneRecords = calStarRecords.Select(calStar => new Cornerstone
                    {
                        IDNumber = calStar.PrimarySSN,
                        LastName = calStar.LastName,
                        FirstName = calStar.FirstName,
                        MiddleInt = calStar.MI,
                        DOB = calStar.DateOfBirth,
                        Gender = calStar.Sex,
                        HireDate = calStar.DateOfHire,
                        CoverageCode = calStar.Coverage1,
                        PlanName = calStar.PlanSelected1,
                        CoverageEffDate = calStar.BenefitStartDate,
                        CoverageExpDate = calStar.BenefitTermDate,
                        Location = calStar.Address,
                        Relationship = calStar.EmployeeID,
                        SSN = calStar.PrimarySSN,
                        DepFirstName = calStar.PrimaryBeneficiaryFirstName,
                        DepLastName = calStar.PrimaryBeneficiaryLastName,
                        DepGender = calStar.Sex,
                        DepDOB = calStar.DateOfBirth,
                        DependentDisabled = calStar.IncludeSpouseCoverage,
                        Address1 = calStar.Address,
                        City = calStar.City,
                        State = calStar.State,
                        ZipCode = calStar.ZipCode,
                        HomePhone = calStar.PhoneNumber,
                        EmployeeTermDate = calStar.BenefitTermDate,
                        DepTermDate = calStar.BenefitTermDate,
                        LocationCodeAbbr = calStar.CountryOfCitizenship,
                        Department = calStar.EmailAddress,
                        ApplicationDate = calStar.BenefitStartDate,
                        ACDStatus = calStar.COBRA,
                        ACDReason = calStar.ElectronicCertificateDelivery,
                        HaveOtherCoverageQuestion = calStar.COBRA,
                        OtherInsCarriersName = calStar.CountryOfCitizenship,
                        NumberOfIDCards = string.Empty,
                        GroupID = string.Empty,
                        PlanCode = calStar.PlanSelected1
                    }).ToList();


                    // Write CSV file
                    using (var writer = new FileStream(cornerstoneFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    using (var csvWriter = new CsvWriter(new StreamWriter(writer), new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        csvWriter.WriteRecords(cornerstoneRecords);
                    }

                    MessageBox.Show("Conversion completed successfully.");


                    //Download CSV file
                    saveFileDialog1.FileName = tempFileName;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(cornerstoneFilePath, saveFileDialog1.FileName, true);
                        MessageBox.Show("File downloaded successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (File.Exists(cornerstoneFilePath))
                {
                    File.Delete(cornerstoneFilePath);
                }
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Additional setup after form load
        }
    }
}
