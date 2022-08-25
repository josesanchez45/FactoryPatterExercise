using FactoryPattern;

Console.WriteLine(" Enter in a number 2 or 4");
var customerNumber = int.TryParse (Console.ReadLine(), out int userInput);
Console.WriteLine();

var instance = VehicleFactory.GetVehichle(userInput);

instance.Drive();
