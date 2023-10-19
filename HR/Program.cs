class Employee
{
    public int EmployeeCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void RemoveFromCompany()
    {
        // عملیات حذف کارمند از شرکت
        Console.WriteLine("کارمند با موفقیت از شرکت حذف شد.");
    }
}

class EmployeeManagement
{
    List<Employee> employees;

    public EmployeeManagement()
    {
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine("کارمند جدید با موفقیت اضافه شد.");
    }

    public void RemoveEmployee(int employeeCode)
    {
        Employee employeeToRemove = employees.FirstOrDefault(e => e.EmployeeCode == employeeCode);
        if (employeeToRemove != null)
        {
            employeeToRemove.RemoveFromCompany();
            employees.Remove(employeeToRemove);
        }
        else
        {
            Console.WriteLine("کارمندی با این کد یافت نشد.");
        }
    }

    public void DisplayEmployees()
    {
        Console.WriteLine("لیست کارمندان:");
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"کد: {employee.EmployeeCode} - نام: {employee.FirstName} {employee.LastName}");
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        EmployeeManagement employeeManagement = new EmployeeManagement();

        // اضافه کردن کارمندان
        Employee employee1 = new Employee { EmployeeCode = 1, FirstName = "John", LastName = "Doe" };
        employeeManagement.AddEmployee(employee1);

        Employee employee2 = new Employee { EmployeeCode = 2, FirstName = "Jane", LastName = "Smith" };
        employeeManagement.AddEmployee(employee2);

        // نمایش لیست کارمندان
        employeeManagement.DisplayEmployees();

        // حذف کارمند با کد 1
        employeeManagement.RemoveEmployee(1);

        // نمایش لیست کارمندان بعد از حذف
        employeeManagement.DisplayEmployees();

        Console.ReadLine();
    }
}
