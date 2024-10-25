using Tyuiu.StoyakinNM.Sprint3.Task7.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание 7                                                               *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу которая выводит таблицу значений функции:            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*        5x + 2,5                                                         *");
        Console.WriteLine("* F(x)= ----------- + 2x + Cos(x)                                         *");
        Console.WriteLine("*        Sin(x) + 3                                                       *");
        Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.*");
        Console.WriteLine("* Произвести проверку деления на 0. При делении на ноль вернуть значение 0*");
        Console.WriteLine("* Значения занести в массив. Значения округлить до двух знаков после      *");
        Console.WriteLine("* запятой.                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+------------+------------+");
        Console.WriteLine("|      X     |     F(x)   |");
        Console.WriteLine("+------------+------------+");
        for(int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}       |{1,5:f1}       |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+------------+------------+");
        Console.ReadKey();
    }
}