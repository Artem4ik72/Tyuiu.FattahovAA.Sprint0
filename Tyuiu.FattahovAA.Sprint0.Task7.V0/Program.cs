using Tyuiu.FattahovAA.Sprint0.Task7.V0.Lib;
Console.Title = "Спринт #0 | Выполнил: Фаттахов А. А. | РППб-26-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #0                                                               *");
Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #0                                                              *");
Console.WriteLine("* Выполнил: Фаттахов Артём Анурович | РППб-26-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
Console.WriteLine("* одиныковых массивов по длинне.                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] arrayInts1 = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Значение элементов массива №1");
for (int i = 0; i < arrayInts1.Length; i++)
{
    Console.Write($"{arrayInts1[i]}, ");
}

Console.WriteLine();

int[] arrayInts2 = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Значение элементов массива №2");
for (int i = 0; i < arrayInts2.Length; i++)
{
    Console.Write($"{arrayInts2[i]}, ");
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
if (arrayInts1.Length == arrayInts2.Length)
{
    int[] result = DataService.AdditionArrays(arrayInts1, arrayInts2);

    Console.WriteLine("Сумма элементов массива ровна:");
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"{result[i]}, ");
    }
}
else
{
    Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
}
Console.ReadKey();