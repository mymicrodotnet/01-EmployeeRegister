using Xunit;

public class EmployeeTests
{
    [Fact] //Marks this method as a test
    public void Employee_ShouldStoreNameAndSalary()
    {
        Employee employee = new Employee("Anna", 35000); // Creates an Employee

        Assert.Equal("Anna", employee.Name); // Checks that the name is "Anna"
        Assert.Equal(35000, employee.Salary); // Checks that the salary is 35000
    }
}