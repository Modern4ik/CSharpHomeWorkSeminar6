// Программа по поиску точки пересечения двух прямых , заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.

Console.Clear();

Console.WriteLine("Введите данные для уравнений, которые задают две прямые: y = k1 * x + b1, y = k * x + b2");
Console.WriteLine();

double valueB1 = GetNumberFromUser("Введите значение b1: ", "Ошибка ввода.Повторите попытку!");
double valueK1 = GetNumberFromUser("Введите значение k1: ", "Ошибка ввода.Повторите попытку!");
double valueB2 = GetNumberFromUser("Введите значение b2: ", "Ошибка ввода.Повторите попытку!");
double valueK2 = GetNumberFromUser("Введите значение k2: ", "Ошибка ввода.Повторите попытку!");

double pointX = GetXCoordOFIntersectPoint(valueB1, valueK1, valueB2, valueK2);
Console.WriteLine();
Console.WriteLine($"Координата X = {pointX}");

double pointY = GetYCoordOfIntersectPoint(valueB1, valueK1, pointX);
Console.WriteLine();
Console.WriteLine($"Координата Y = {pointY}");

PrintReport(pointX, pointY);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Methods

double GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out double userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double GetXCoordOFIntersectPoint(double b1, double k1, double b2, double k2)
{

    b2 = b2 - b1;
    k1 = k1 - k2;
    double x = b2 / k1;

    return x;
}

double GetYCoordOfIntersectPoint(double b1, double k1, double x)
{
    double y = k1 * x + b1;

    return y;
}

void PrintReport(double x, double y)
{
    Console.WriteLine();
    Console.WriteLine($"Координаты точки пересечения двух прямых заданных данными уравнениями -> ({x};{y})");
}

#endregion