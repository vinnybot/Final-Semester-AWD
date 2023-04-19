namespace QuarterlySalesApp.Models.Validation
{
    public static class Validate
    {
        public static string CheckEmployee(QuarterlyContext context, Employee employee)
        {
            var dbEmp = context.Employees.FirstOrDefault(e => e.Name == employee.Name && e.LastName == employee.LastName && e.DOB == employee.DOB);

            if (dbEmp == null)
            {
                return "";
            }
            else
            {
                return $"{employee.Name} (DOB:{employee.DOB?.ToShortDateString()}) is already in the database.";
            }
        }

        public static string CheckManagerEmployeeMatch(QuarterlyContext context, Employee employee)
        {
            var manager = context.Employees.Find(employee.ManagerId);

            if (manager != null && 
                manager.Name == employee.Name &&
                manager.LastName == employee.LastName &&
                manager.DOB == employee.DOB)
            {
                return $"Manager and employee cannot be the same person.";
            }
            else
            {
                return "";
            }
        }
        public static string CheckSales(QuarterlyContext context, Sale s1)
        {
            Sale? dbSale = context.Sales.FirstOrDefault(s =>
            s.Quarter == s1.Quarter &&
            s.Year == s1.Year &&
            s.EmployeeId == s1.EmployeeId);

            if (dbSale == null)
            {
                return "";
                //empty string for valid
            } else
            {
                var emp = context.Employees.Find(s1.EmployeeId);
                return $"Sales for {emp?.FullName} for {s1.Year} Q{s1.Quarter} are already in the database.";
                //invalid data - error string
            }
        }
    }
}
