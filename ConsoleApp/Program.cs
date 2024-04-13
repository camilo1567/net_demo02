using MyLibrary;

Secretary Maria = new Secretary();
Maria.Name = "Maria";

Manager Pedro = new Manager();
Pedro.Name = "Pedro";

WriteEmployeeInfo(Maria);
WriteEmployeeInfo(Pedro);

void WriteEmployeeInfo(Employee employee)
{
    Console.WriteLine($"{employee.Name}: {employee.CalculateMonthlyPayment()}");
}