using CalStar;
using CsvHelper.Configuration;

public class CornerstoneMap : ClassMap<Cornerstone>
{
    public CornerstoneMap()
    {
        Map(m => m.IDNumber).Name("IDNumber");
        Map(m => m.LastName).Name("LastName");
        Map(m => m.FirstName).Name("FirstName");
        Map(m => m.MiddleInt).Name("MiddleInt");
        Map(m => m.DOB).Name("DOB");
        Map(m => m.Gender).Name("Gender");
        Map(m => m.HireDate).Name("HireDate");
        Map(m => m.CoverageCode).Name("CoverageCode");
        Map(m => m.PlanName).Name("PlanName");
        Map(m => m.CoverageEffDate).Name("CoverageEffDate");
        Map(m => m.CoverageExpDate).Name("CoverageExpDate");
        Map(m => m.Location).Name("Location");
        Map(m => m.Relationship).Name("Relationship");
        Map(m => m.SSN).Name("SSN");
        Map(m => m.DepFirstName).Name("DepFirstName");
        Map(m => m.DepLastName).Name("DepLastName");
        Map(m => m.DepGender).Name("DepGender");
        Map(m => m.DepDOB).Name("DepDOB");
        Map(m => m.DependentDisabled).Name("DependentDisabled");
        Map(m => m.Address1).Name("Address1");
        Map(m => m.City).Name("City");
        Map(m => m.State).Name("State");
        Map(m => m.ZipCode).Name("ZipCode");
        Map(m => m.HomePhone).Name("HomePhone");
        Map(m => m.EmployeeTermDate).Name("EmployeeTermDate");
        Map(m => m.DepTermDate).Name("DepTermDate");
        Map(m => m.LocationCodeAbbr).Name("LocationCodeAbbr");
        Map(m => m.Department).Name("Department");
        Map(m => m.ApplicationDate).Name("ApplicationDate");
        Map(m => m.ACDStatus).Name("ACDStatus");
        Map(m => m.ACDReason).Name("ACDReason");
        Map(m => m.HaveOtherCoverageQuestion).Name("HaveOtherCoverageQuestion");
        Map(m => m.OtherInsCarriersName).Name("OtherInsCarriersName");
        Map(m => m.NumberOfIDCards).Name("NumberOfIDCards");
        Map(m => m.GroupID).Name("GroupID");
        Map(m => m.PlanCode).Name("PlanCode");
        Map(m => m.EmailAddress).Name("EmailAddress");
        Map(m => m.Address2).Name("Address2");
    }
}
