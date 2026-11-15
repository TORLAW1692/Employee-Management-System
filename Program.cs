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
        case "2":
        case "3":
        case "4":
        case "5":
            Console.WriteLine("\nThis feature is under development.");
            break;

        case "6":
            Console.WriteLine("\nThank you for using the Employee Management System!");
            running = false;
            break;

        default:
            Console.WriteLine("\nInvalid selection. Please try again.");
            break;
    }
}