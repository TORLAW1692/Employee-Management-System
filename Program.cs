bool running = true;

while (running)
{
    Console.WriteLine("\n========================================");
    Console.WriteLine("       EMPLOYEE MANAGEMENT SYSTEM");
    Console.WriteLine("========================================");
    Console.WriteLine("\nWelcome! Select an option and press Enter.");

    Console.WriteLine("\nMAIN MENU");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1. View All Employees");
    Console.WriteLine("2. View Employees by Type");
    Console.WriteLine("3. Add Employee");
    Console.WriteLine("4. Update Employee");
    Console.WriteLine("5. Remove Employee");
    Console.WriteLine("6. Exit");

    Console.Write("\nEnter your selection: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
case "1":
    // Create realistic employee records using derived classes (inheritance).
    List<Employee> employees = new List<Employee>
    {
        new HourlyEmployee(1001, "Marcus Johnson", "Maintenance", 18.50m),
        new SalariedEmployee(1002, "Sarah Mitchell", "Human Resources", 58000m)
    };

    Console.WriteLine("\nEMPLOYEE DIRECTORY");
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine($"{"ID",-6} {"Name",-20} {"Department",-18} {"Type",-10} {"Pay",-15}");
    Console.WriteLine("--------------------------------------------------------------------------");

    foreach (Employee employee in employees)
    {
        // Access Department information through composition.
        Console.WriteLine(
            $"{employee.Id,-6} {employee.Name,-20} " +
            $"{employee.Department.Name,-18} {employee.EmploymentType,-10} " +
            $"{employee.PayDisplay,-15}"
        );
    }

    Console.WriteLine("--------------------------------------------------------------------------");
    break;

case "2":
case "3":
case "4":
case "5":
    Console.WriteLine("\nThis feature is under development.");
    break;

        default:
            Console.WriteLine("\nInvalid selection. Please try again.");
            break;
case "6":
    Console.WriteLine("\nThank you for using the Employee Management System!");
    running = false;
    break;
    }
}