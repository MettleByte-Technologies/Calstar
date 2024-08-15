using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

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
                    MissingFieldFound = null,
                    BadDataFound = null
                };

                using (var reader = new FileStream(txtInputFile.Text, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var calStarCsvReader = new CsvReader(new StreamReader(reader), csvConfig))
                {
                    // Read CSV file
                    calStarCsvReader.Context.RegisterClassMap<CalStarMap>();
                    var calStarRecords = calStarCsvReader.GetRecords<CalStar>().ToList();

                    // Debug: Check if records are being read
                    if (!calStarRecords.Any())
                    {
                        MessageBox.Show("No records found in the input file.");
                        return;
                    }

                    Cornerstone previousCornerstoneRecord = null;
                    // Convert Calstar to Cornerstone
                    var cornerstoneRecords = calStarRecords
                        .Where(calStar => !string.IsNullOrEmpty(calStar.FirstName)) // Filter records with non-empty FirstName
                        .Select(calStar => //new Cornerstone
                    {
                        var currentCornerstone = new Cornerstone
                        {
                            IDNumber = calStar.EmployeeID,
                            LastName = calStar.LastName,
                           // PreviousFirstName = previousCornerstoneRecord?.FirstName,
                            FirstName = (calStar.InsuredType == "S" || calStar.InsuredType == "D") ? previousCornerstoneRecord?.FirstName : calStar.FirstName,
                            MiddleInt = (calStar.InsuredType == "S" || calStar.InsuredType == "D") ? previousCornerstoneRecord?.MiddleInt : calStar.MI,
                            DOB = calStar.DateOfBirth?.ToString("yyyyMMdd"),
                            Gender = calStar.Sex,
                            HireDate = calStar.DateOfHire?.ToString("yyyyMMdd"),
                            CoverageCode = calStar.Coverage1,
                            PlanName = calStar.PlanSelected1,
                            CoverageEffDate = (calStar.BenefitStartDate?.ToString("yyyyMMdd")),
                            CoverageExpDate = (calStar.BenefitTermDate?.ToString("yyyyMMdd")),
                            Location = "01-MBR America",
                            Relationship = calStar.InsuredType,
                            SSN = calStar.PrimarySSN,
                            DepFirstName = (calStar.InsuredType == "S" || calStar.InsuredType == "D") ? calStar.FirstName : string.Empty,
                            DepLastName = (calStar.InsuredType == "S" || calStar.InsuredType == "D") ? calStar.LastName : string.Empty,
                            DepGender = calStar.Sex,
                            DepDOB = (calStar.DateOfBirth?.ToString("yyyyMMdd")),
                            DependentDisabled = calStar.IncludeSpouseCoverage,
                            Address1 = calStar.Address,
                            City = calStar.City,
                            State = calStar.State,
                            ZipCode = calStar.ZipCode,
                            HomePhone = calStar.PhoneNumber,
                            EmployeeTermDate = (calStar.BenefitTermDate?.ToString("yyyyMMdd")),
                            DepTermDate = (calStar.BenefitTermDate?.ToString("yyyyMMdd")),
                            LocationCodeAbbr = "01-MBR America",
                            Department = string.Empty,
                            ApplicationDate = (calStar.BenefitStartDate?.ToString("yyyyMMdd")),
                            ACDStatus = calStar.COBRA,
                            ACDReason = calStar.ElectronicCertificateDelivery,
                            HaveOtherCoverageQuestion = calStar.COBRA,
                            OtherInsCarriersName = calStar.CountryOfCitizenship,
                            NumberOfIDCards = string.Empty,
                            GroupID = "MA11011",
                            PlanCode = "MBR",
                            EmailAddress = calStar.EmailAddress
                        };

                        // Update the previous record reference to the current one
                        previousCornerstoneRecord = currentCornerstone;

                        return currentCornerstone;

                    }).ToList();

                    // Write CSV file
                    using (var writer = new FileStream(cornerstoneFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    using (var csvWriter = new CsvWriter(new StreamWriter(writer), csvConfig))
                    {
                        csvWriter.WriteRecords(cornerstoneRecords);
                    }

                    MessageBox.Show("Conversion completed successfully.");

                    // Download CSV file
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

        private DateTime? ParseDate(string dateString)
        {
            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                return date;
            }
            return null; // Return null if parsing fails
        }


        private string FormatDate(DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("yyyyMMdd") : string.Empty;
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
