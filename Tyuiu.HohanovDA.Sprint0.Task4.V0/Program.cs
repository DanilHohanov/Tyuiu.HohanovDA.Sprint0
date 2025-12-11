using Tyuiu.HohanovDA.Sprint0.Task4.V0.Lib;
// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        // Пример линейной структуры

        // Вызов метода сложения Addition
        Console.WriteLine(DataService.Addition(1, 5));
        // Вызов метода сложения Subtraction
        Console.WriteLine(DataService.Subtraction(15, 5));
        // Вызов метода сложения Multiplication
        Console.WriteLine(DataService.Multiplication(10, 10));
        // Вызов метода сложения Division
        Console.WriteLine(DataService.Division(5, 5));

        Console.ReadKey();
    }
}