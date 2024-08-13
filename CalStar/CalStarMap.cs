using CsvHelper.Configuration;

namespace CalStar
{
    public class CalStarMap : ClassMap<CalStar>
    {
        public CalStarMap()
        {
            Map(m => m.Division).Name("Division");
            Map(m => m.PrimarySSN).Name("Primary SSN");
            Map(m => m.InsuredType).Name("Insured Type");
            Map(m => m.LastName).Name("Last Name");
            Map(m => m.FirstName).Name("First Name");
            Map(m => m.MI).Name("MI");
            Map(m => m.Sex).Name("Sex");
            Map(m => m.Age).Name("Age\n(Auto Calculated)");
            Map(m => m.DateOfBirth).Name("Date of Birth (MM/DD/YYYY)");
            Map(m => m.SocialSecurityNo).Name("Social Security No.");
            Map(m => m.Address).Name("Address");
            Map(m => m.Address2).Name("Address2");
            Map(m => m.City).Name("City");
            Map(m => m.State).Name("State");
            Map(m => m.ZipCode).Name("Zip Code");
            Map(m => m.MonthlyPremium1).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected1).Name("Plan Selected");
            Map(m => m.Coverage1).Name("Coverage");
            Map(m => m.CountryOfCitizenship).Name("If not a US citizen, enter country of citizenship");
            Map(m => m.COBRA).Name("COBRA");
            Map(m => m.COBRAStartDate).Name("COBRA\nStart Date");
            Map(m => m.ActivelyAtWork).Name("Actively at Work            (Y=yes or N=no)");
            Map(m => m.ElectronicCertificateDelivery).Name("Does employee agree to electronic certificate delivery?\nY=yes or N=no");
            Map(m => m.EmailAddress).Name("Email Address");
            Map(m => m.BenefitStartDate).Name("Benefit Start Date");
            Map(m => m.BenefitTermDate).Name("Benefit Term Date");
            Map(m => m.ChangeDate).Name("Change Date");
            Map(m => m.DateOfHire).Name("Date of Hire");
            Map(m => m.PhoneNumber).Name("Phone Number");
            Map(m => m.MonthlyPremium2).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected2).Name("Plan Selected");
            Map(m => m.Coverage2).Name("Coverage");
            Map(m => m.MonthlyPremium3).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected3).Name("Plan Selected");
            Map(m => m.Coverage3).Name("Coverage");
            Map(m => m.GroupAccidentPrimaryBeneficiaryLastName).Name("Group Accident Primary Beneficiary Last Name");
            Map(m => m.GroupAccidentPrimaryBeneficiaryFirstName).Name("Group Accident Primary Beneficiary First Name");
            Map(m => m.GroupAccidentPrimaryBeneficiaryRelationship).Name("Group Accident Primary Beneficiary Relationship");
            Map(m => m.GroupAccidentContingentBeneficiaryLastName).Name("Group Accident Contingent Beneficiary Last Name");
            Map(m => m.GroupAccidentContingentBeneficiaryFirstName).Name("Group Accident Contingent Beneficiary First Name");
            Map(m => m.GroupAccidentContingentBeneficiaryRelationship).Name("Group Accident Contingent Beneficiary Relationship");
            Map(m => m.MonthlyPremium4).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected4).Name("Plan Selected");
            Map(m => m.Coverage4).Name("Coverage");
            Map(m => m.NicotineUse36Months).Name("Nicotine use in last 36 months: Y=yes or N=no\n(Leave blank if uni-nicotine rates)");
            Map(m => m.MonthlyPremium5).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected5).Name("Plan Selected");
            Map(m => m.MonthlyBenefitAmount).Name("Monthly Benefit Amount");
            Map(m => m.MonthlySalary).Name("Monthly Salary");
            Map(m => m.SalaryType).Name("Salary\n(M=monthly or A=annually)");
            Map(m => m.BeneficiaryFirstName).Name("Beneficiary First Name");
            Map(m => m.BeneficiaryMiddleName).Name("Beneficiary Middle Name");
            Map(m => m.BeneficiaryLastName).Name("Beneficiary Last Name");
            Map(m => m.BeneficiaryRelationshipToInsured).Name("Beneficiary Relationship to Insured");
            Map(m => m.BeneficiaryCountryOfCitizenship).Name("Beneficiary Country of Citizenship");
            Map(m => m.MonthlyPremium6).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected6).Name("Plan Selected");
            Map(m => m.Coverage5).Name("Coverage");
            Map(m => m.PrimaryBeneficiaryLastName).Name("Primary Beneficiary Last Name");
            Map(m => m.PrimaryBeneficiaryFirstName).Name("Primary Beneficiary First Name");
            Map(m => m.PrimaryBeneficiaryRelationship).Name("Primary Beneficiary Relationship");
            Map(m => m.ContingentBeneficiaryLastName).Name("Contingent Beneficiary Last Name");
            Map(m => m.ContingentBeneficiaryFirstName).Name("Contingent Beneficiary First Name");
            Map(m => m.ContingentBeneficiaryRelationship).Name("Contingent Beneficiary Relationship");
            Map(m => m.MonthlyPremium7).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected7).Name("Plan Selected");
            Map(m => m.Coverage6).Name("Coverage");
            Map(m => m.MonthlyPremium8).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected8).Name("Plan Selected");
            Map(m => m.FaceAmount).Name("Face Amount");
            Map(m => m.IncludeSpouseCoverage).Name("Include Spouse Coverage: Y=yes or N=no");
            Map(m => m.IncludeChildCoverage).Name("Include Child Coverage: Y=yes or N=no");
            Map(m => m.NicotineUse12Months).Name("Nicotine use in last 12 months: Y=yes or N=no\n(Leave blank if uni-nicotine rates)");
            Map(m => m.EmployeeID).Name("Employee ID");
            Map(m => m.MonthlyPremium9).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected9).Name("Plan Selected");
            Map(m => m.Coverage7).Name("Coverage");
            Map(m => m.MonthlyPremium10).Name("Monthly Premium\n(Click for drop-down for other premium mode)");
            Map(m => m.PlanSelected10).Name("Plan Selected");
            Map(m => m.Coverage8).Name("Coverage");
        }
    }
}
