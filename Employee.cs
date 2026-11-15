// Developer: Tory Lawson
// Date: November 15, 2026
// Purpose: Base class containing information shared by all employees.

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Department Department { get; set; }

    public string EmploymentType { get; protected set; }
    public string PayDisplay { get; protected set; }

    public Employee(int id, string name, string departmentName)
    {
        Id = id;
        Name = name;

        // COMPOSITION:
        // An Employee contains a Department object.
        Department = new Department(departmentName);

        EmploymentType = "Employee";
        PayDisplay = "N/A";
    }
}