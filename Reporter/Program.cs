using Reporter;

List<Employee> employees = new()
{
    new Employee { Name = "John", Salary = 150},
    new Employee { Name = "Tom", Salary = 270 },
    new Employee { Name = "Anna", Salary = 130 }
};

var builder = new EmployeeReportBuilder(employees);

//builder.BuildHeader().BuildBody().BuildFooter();

var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);