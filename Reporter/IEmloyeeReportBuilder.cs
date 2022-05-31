namespace Reporter
{
    public interface IEmloyeeReportBuilder
    {
        EmployeeReportBuilder BuildHeader();

        EmployeeReportBuilder BuildBody();

        EmployeeReportBuilder BuildFooter();

        EmployeeReport GetReport();
    }
}
