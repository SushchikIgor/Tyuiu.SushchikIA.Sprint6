using Tyuiu.SushchikIA.Sprint6.Task2.V19.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #6 | Выполнил: Сущик И.А. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #6                                                               *");
Console.WriteLine("* Тема: Операции сравнения в C#                                           *");
Console.WriteLine("* Задание #Task2                                                          *");
Console.WriteLine("* Вариант #                                                               *");
Console.WriteLine("* Выполнил: Сущик Игорь Александрович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


double[] res = ds.GetMassFunction(10, 12);

Console.WriteLine(res);