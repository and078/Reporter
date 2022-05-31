namespace Reporter
{
    public class EmployeeReportDirector
    {
        private readonly IEmloyeeReportBuilder _builder;

        public EmployeeReportDirector(IEmloyeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.BuildHeader()

            .BuildBody()

            .BuildFooter();
        }
    }
}
