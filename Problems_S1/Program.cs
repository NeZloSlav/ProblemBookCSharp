
// S1. Простейшие программы. Арифметические выражения.

#region Задача S1.1

while (true)
{
    Console.WriteLine("Введите число: ");

    try
    {
        double fullNumber = Convert.ToDouble(Console.ReadLine());

        double numberWithHundredth;

        //Способ 1

        numberWithHundredth = Math.Round(fullNumber, 2);

        Console.WriteLine(numberWithHundredth);

        //Способ 2

        string convertedNumber = Convert.ToString(numberWithHundredth);

        string beforeSeparator = convertedNumber.Substring(0, convertedNumber.IndexOf(','));

        Console.WriteLine(beforeSeparator);

        string afterSeparator = convertedNumber.Substring(convertedNumber.IndexOf(',') + 1);

        if (afterSeparator.Length < 2)
        {
            afterSeparator += "0";
        }
        if (afterSeparator is null)
        {
            afterSeparator = "00";
        }

        Console.WriteLine(afterSeparator);
    }
    catch (Exception)
    {
        Console.WriteLine("Введите корректное значение");
    }
}

#endregion

