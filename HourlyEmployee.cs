// Developer: Tory Lawson
// Date: November 15, 2026
// Purpose: Represents employees who receive hourly wages.

// INHERITANCE:
// HourlyEmployee derives from the Employee base class.

public class HourlyEmployee : Employee
{
    public decimal HourlyRate { get; set; }

    public HourlyEmployee(
        int id,
        string name,
        string departmentName,
        decimal hourlyRate)
        : base(id, name, departmentName)
    {
        HourlyRate = hourlyRate;
        EmploymentType = "Hourly";
        PayDisplay = $"{HourlyRate:C2}/hr";
    }
}