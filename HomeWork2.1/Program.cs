using System;

class Test
{
    static void Main()
    {
        Console.WriteLine("Введите целое число");
        int number = int.Parse(Console.ReadLine());
        int cube = number * number * number;
        Console.WriteLine("Куб введеного числа" + cube);
        Console.ReadKey();
    }
}