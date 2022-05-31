using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public class EmployeeReportBuilder : IEmloyeeReportBuilder
    {
        private EmployeeReport _employeeReport;

        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new();
        }


        public EmployeeReportBuilder BuildHeader()
        {
            _employeeReport.Header =
                $"EMPLOYEE REPORT ON DATE {DateTime.Now}\n";

            _employeeReport.Header +=
                "\n--------------------------------------------------------------------------------------------------------------------\n";
            return this;
        }

        public EmployeeReportBuilder BuildBody()
        {
            _employeeReport.Body =
                string.Join(Environment.NewLine,
                    _employees.Select(e => $"Empoyee: {e.Name}\t\tSalary: {e.Salary} Euro")            
                    );
            return this;
        }

        public EmployeeReportBuilder BuildFooter()
        {
            _employeeReport.Footer =
                "\n--------------------------------------------------------------------------------------------------------------------\n";

            _employeeReport.Footer +=
                $"\nTOTAL EMPLOYEES: {_employees.Count()} TOTAL SALARY: {_employees.Sum(e => e.Salary)} Euro";
            return this;
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;
            
            _employeeReport = new();
            
            return employeeReport;
        }
    }
}
