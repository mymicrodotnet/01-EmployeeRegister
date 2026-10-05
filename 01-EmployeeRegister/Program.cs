using System;
/*
Top-level statements must precede namespace and type declarations.
type (class, struct, etc.)
TOP-LEVEL STATEMENTS
        ↓
class / struct / etc.
*/

// now we will be able to create an employee like this
// Employee employee = new Employee("John", 30000);
// Console.WriteLine(employee.Name);
// Console.WriteLine(employee.Salary);
// employee.Name = "Peter";
// Console.WriteLine(employee.Name);
// Employee employee1 = new Employee("John", 30_000);
// employees.Add(employee1);
// employee1.DisplayInfo();

List<Employee> employees = new List<Employee>();


while (true)
{
    Console.WriteLine("\nEmployee Register");
    Console.WriteLine("1. Register employee");
    Console.WriteLine("2. Show employees");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            // register employee
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine()!;

            // name validation null or empty string
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.");
                break;
            }

            Console.Write("Enter employee salary: ");

            // salary validation 1
            if (!int.TryParse(Console.ReadLine(), out int salary)) // if TryParse is NOT successful. Create/use the variable salary and let TryParse put the converted number into salary
            {
                Console.WriteLine("Invalid salary."); // If the salary cannot be converted to an int, show an error
                break;
            }

            // salary validation 2
            if (salary < 0)
            {
                Console.WriteLine("Salary cannot be negative.");
                break;
            }

            Employee newEmployee = new Employee(name, salary); // employee is invalid
            employees.Add(newEmployee);
            break;

        case "2":
            // show employees
            foreach (Employee employee in employees)
            {
                employee.DisplayInfo();
            }

            break;

        case "3":
            // exit
            return;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}


// Class declaration
class Employee
{
    // This is get, set
    public string Name { get; set; }
    public int Salary { get; set; }

    // This is the constructor
    public Employee(string name, int salary) // parameters
    {
        Name = name;// Property Name = parameter name or this.Nmae=name
        Salary = salary;// Property Salary = parameter salary or this.Salary=salary
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"Name: {Name} Salary: {Salary}");
    }

}

