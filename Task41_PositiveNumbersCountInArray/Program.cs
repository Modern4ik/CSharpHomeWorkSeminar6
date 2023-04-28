// Программа для подсчета чисел больше 0 , которые ввёл пользователей.

Console.Clear();

int arrayLenght = GetNumberFromUser("Введите размер массива, не равный 0: ", "Ошибка ввода.Повторите попытку!");

int[] userArray = GetArrayElemFromUser(arrayLenght);
Console.WriteLine();
Console.WriteLine($"При использовании введёных вами данных, сгенерирован массив чисел из {arrayLenght} элементов -> {String.Join(" ", userArray)}");

int result = CheckMoreThanZeroNumbCountInUserArray(userArray);

PrintReport(result);

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

#region Methods

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber) && userNumber > 0)
        {
            return userNumber;
        }
        Console.WriteLine(errorMessage);
    }
}

int[] GetArrayElemFromUser(int size)
{
    int[] array = new int[size];
    int i = 0;

    while (i < array.Length)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        if (int.TryParse(Console.ReadLine(), out array[i]))
        {
            i++;
        }
        else
        {
            Console.WriteLine("Ошибка ввода.Повторите попытку!");
        }
    }

    return array;
}

int CheckMoreThanZeroNumbCountInUserArray(int[] arr)
{
    int count = 0;

    foreach (int el in arr)
    {
        if (el > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintReport(int count)
{
    Console.WriteLine();
    Console.Write($"Количество чисел в данном массиве , которые больше 0 , равняется -> {count}");
}

#endregion