using MyLibrary;

Secretary Maria = new Secretary();
Maria.Name = "Maria";

Manager Pedro = new Manager();
Pedro.Name = "Pedro";

Developer Camilo = new Developer();
Camilo.Name = "Camilo";

WriteEmployeeInfo(Maria);
WriteEmployeeInfo(Camilo);
WriteEmployeeInfo(Pedro);

Console.WriteLine(Camilo.GetPaymentDays());

void WriteEmployeeInfo(Employee employee)
{
    Console.WriteLine($"{employee.Name}: {employee.CalculateMonthlyPayment()}");
    Console.WriteLine($"Days: {employee.GetPaymentDays()}");
}