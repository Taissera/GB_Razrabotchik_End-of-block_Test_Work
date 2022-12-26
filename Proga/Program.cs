Console.WriteLine("Введите несколько значений (слов/чисел) разной длины.");
Console.WriteLine("Программа выведет только те значения, где количество символов <= 3.");

// получение числа с консоли, для того, чтобы задать размерность массива
// (задаётся пользователем)
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число");
        }
    }
    return result;
}

int arrayLen = GetNumberFromConsole("Сколько значений Вы хотите ввести? Введите число (количество).");

//Объявляем массив строк длиной arrayLen (которую ввёл пользователь)
string?[] arrayStr1 = new string[arrayLen]; 
//Заполняем массив
for (int i = 0; i < arrayLen; i++)
{
    Console.Write("Введите значение №{0}:\r\n    ", i + 1);
    arrayStr1[i] = Console.ReadLine(); 
}
// выводим массив
Console.WriteLine("Вы ввели следующие значения");
Console.Write("[    ");
for (int i = 0; i < arrayLen; i++)
{
    Console.Write($"{arrayStr1[i]}   ");
}
Console.WriteLine("]");


// на основании исходного массива задаём второй массив, длина элементов которого <= 3
void ResultArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

// печать массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] arrayStr2 = new string[arrayStr1.Length];
ResultArray(arrayStr1!, arrayStr2);
Console.WriteLine("Значения, где количество символов <= 3:");
PrintArray(arrayStr2);