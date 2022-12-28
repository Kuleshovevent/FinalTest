
void ZadachaFinal()
{
    Console.Clear();
    string[] ArrayStrings = new string[] { };
    Console.Write("Введите количество элементов массива - строк:");
    int n = int.Parse(Console.ReadLine());
    ArrayStrings = new string[n];
    for (int i = 0; i < ArrayStrings.Length; i++)
    {
        Console.Write($" Введите {i + 1} строку: ");
        ArrayStrings[i] = Console.ReadLine();
    }
    Console.WriteLine();
    Console.WriteLine("массив введенных данных:");
    Console.WriteLine($"{PrintArray(ArrayStrings)}");
    Console.WriteLine();

    int length = 3;  // задаем парметр длины элемент массива

    int numbers = CheckArray(ArrayStrings, length); 
    // вводим новую переменную в которую будем присваивать вычесленный
    // элемент массива меньше либо равна 3 символа

 
}
ZadachaFinal();

string PrintArray(string [] array) // функция вывода массива
{
        string result = string.Empty;
        result = "[ ";
        for (int i = 0; i < array.Length; i++)
        {
            result += $"{array[i],1}";
            if (i < array.Length - 1) result += ", ";
        }
        result += " ]";
        return result;
}

// функция определения количества элемента массива длина которых меньше какой-то 
//заданной длины length
int CheckArray(string[] array, int length)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) result++;
    }
    return result;
}