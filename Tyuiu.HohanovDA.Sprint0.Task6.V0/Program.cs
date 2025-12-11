using Tyuiu.HohanovDA.Sprint0.Task6.V0.Lib;
// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
        // Пример линейной структуры наъодится в библиоктеке классов в методе AdditionArray
        Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));

        // Пример линейной структуры наъодится в библиоктеке классов в методе SubtractionArray
        Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));

        // Пример линейной структуры наъодится в библиоктеке классов в методе MultiplicationArray
        Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));
        
        Console.ReadKey();
    }
}