// Developer: Tory Lawson
// Date: November 15, 2026
// Purpose: Represents employees who receive annual salaries.

// INHERITANCE:
// SalariedEmployee derives from the Employee base class.

public class SalariedEmployee : Employee
{
    public decimal AnnualSalary { get; set; }

    public SalariedEmployee(
        int id,
        string name,
        string departmentName,
        decimal annualSalary)
        : base(id, name, departmentName)
    {
        AnnualSalary = annualSalary;
        EmploymentType = "Salaried";
        PayDisplay = $"{AnnualSalary:C0}/yr";
    }
}