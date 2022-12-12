using ConsoleApp7;
using System;

Cube cube = new();
Console.WriteLine("Синий куб окунули в красную краску и разрезали во весех трёх измерениях\n Выберите что вы хотите узнать");
void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Количество разрезов куба");
    Console.WriteLine($"2) Количество кубиков получившихся после разрезов");
    Console.WriteLine($"3) Количество синих кубиков");
    Console.WriteLine($"4) Количество красных кубиков");
    Console.WriteLine();
}
void UseMenu()
{
    while (true)
    {
        GetMenu();
        string choice = Console.ReadLine();
        bool checkChoice = int.TryParse(choice, out int resultChoice);
        if (resultChoice > 4)
        {
            Console.WriteLine($"Выберите пункт из меню");
        }
        else
        {
            Console.WriteLine($"Введите сколько раз произвести действие с кубом");
            string repetition = Console.ReadLine();
            bool checkRepetition = int.TryParse(repetition, out int resultRepetition);
            Console.WriteLine();
            switch (resultChoice)
            {
                case 1:
                    var numberCuts = cube.NumberCuts(resultRepetition);
                    Console.WriteLine($"Разрезов куба: {numberCuts}");
                    break;
                case 2:
                    var numberCubes = cube.NumberCubes(resultRepetition);
                    Console.WriteLine($"кубиков: {numberCubes}");
                    break;
                case 3:
                    var numberBlueCubes = cube.NumberBlueCubes(resultRepetition);
                    Console.WriteLine($"синих кубиков: {numberBlueCubes}");
                    break;
                case 4:
                    var numberRedCubes = cube.NumberRedCubes(resultRepetition);
                    Console.WriteLine($"красных кубиков: {numberRedCubes}");
                    break;
                default:
                    Console.WriteLine($"Выберите пункт из меню");
                    break;
            }
        }
    }
}
UseMenu();