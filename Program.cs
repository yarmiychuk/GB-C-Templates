/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
*/

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);

    return array;
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1} из {size}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("Введённый массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}

int SumOfPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) sum += array[i];
    return sum;
}

int SumOfNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sum += array[i];
    return sum;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите максимальное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] binaryArray = CreateArray(size, min, max);
ShowArray(binaryArray);
Console.WriteLine($"Сумма положительных числе в массиве равна {SumOfPositive(binaryArray)}");
Console.WriteLine($"Сумма отрицательных числе в массиве равна {SumOfNegative(binaryArray)}");

/*
Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
*/
int[] InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;
    return array;
}

int[] array = CreateRandomArray(4, -10, 10);
ShowArray(array);
array = InvertArray(array);
ShowArray(array);

/*
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.
*/
bool IsHere(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == number) return true;
    
    return false;
}

int[] array2 = CreateRandomArray(10, 0, 30);
int find = new Random().Next(0, 31);
ShowArray(array2);
Console.WriteLine(find + " " + IsHere(find, array2));

/*
Задайте одномерный массив из 12 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*/
int CountOf(int min, int max, int[] array) {
    int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] >= min && array[i] <= max) count++;
    return count;
}

int[] array3 = CreateRandomArray(12, 0, 100);
ShowArray(array3);
Console.WriteLine(CountOf(10, 99, array3));

/*
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
*/
int[] NewArray(int[] array)
{
    int[] mathArray = new int[array.Length / 2];
    int min = 0;
    int max = array.Length - 1;
    while (min < max) {
        mathArray[min] = array[min] * array[max];
        min ++;
        max --;
    }
    return mathArray;
}

int size2 = new Random().Next(5, 10);
int[] array4 = CreateRandomArray(size2, 0, 10);
ShowArray(array4);
ShowArray(NewArray(array4));

/*
Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/

int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

// Генерация вещественных чисел
Random rnd = new Random();
double number = rnd.Next(1, 10) + rnd.NextDouble();

/*
Напишите программу, которая принимает на вход три числа
и проверяет, может ли существовать треугольник с сторонами такой длины.
a < b + c;
b < a + c;
c < a + b;
*/

bool IsTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
*/

string ConvertToBinary(int number)
{
    string result = string.Empty; // string = "";
    while (number != 0)
    {
        result = number %2 + result;
    }
    return result;
}

/*
Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
*/

int[] Fibonacci(int size, int a, int b)
{
    int[] result = new int[size];
    result[0] = a;
    result[1] = b;
    for (int i = 0; i < size; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}

/*
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/

int[,] CreateDRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; i < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле:
A[i, j] = i + j. Выведите полученный массив на экран.
*/

int[,] CreateArrayIJ(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = i + j;
        }
    }
    return newArray;
}

/*
Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные, и замените эти элементы на их квадраты.
*/

int[,] EvenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; i < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i, j];
        }
    }
    return array;
}

int[,] array5 = CreateDRandom2DArray(5, 5, 0 , 9);
Show2DArray(array5);
array5 = EvenArray(array5);
Show2DArray(array5);


/*
Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int GetSumOfDiagonal(int[,] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}

int[,] array6 = CreateDRandom2DArray(5, 5, 0 , 9);
Show2DArray(array6);
array5 = EvenArray(array6);
Show2DArray(array6);

/*
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
*/
int[,] ChangeLines(int[,] array, int fromIndex, int toIndex)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[fromIndex, j];
        array[fromIndex, j] = array[toIndex, j];
        array[toIndex, j] = temp;
    }

    return array;
}

/*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

// Пройтись только по одной половине матрицы от главной диагонали
int[,] ReverseRowsCols(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }

    return array;
}

// Сразу Квадратный
int[,] array9 = CreateDRandom2DArray(5, 5, rnd.Next(5, 9), rnd.Next(5, 9));
Show2DArray(array9);
int[,] array10 = ReverseRowsCols(array9);
Show2DArray(array10);


/*
Из двумерного массива целых чисел удалить строку и столбец,
на пересечении которых расположен наименьший элемент.
*/

int[,] RemoveMinimumm(int[,] array)
{
    int lengthX = array.GetLength(0);
    int lengthY = array.GetLength(1);

    // Поиск минимального
    int minX = 0;
    int minY = 0;
    for (int i = 0; i < lengthX; i++)
    {
        for (int j = 0; j < lengthY; j++)
        {
            if (array[i, j] < array[minX, minY])
            {
                minX = i;
                minY = j;
            }
        }
    }

    // Удаление
    int[,] newArray = new int[lengthX - 1, lengthY - 1];
    int newX = 0;
    for (int i = 0; i < lengthX; i++)
    {
        if (i != minX) 
        {
            int newY = 0;
            for (int j = 0; j < lengthY; j++)
            {
                if (j != minY)
                {
                    newArray[newX, newY] = array[i, j];
                    newY++;
                }
            }
            newX++;
        }
    }

    return newArray;
}

int[,] array7 = CreateDRandom2DArray(rnd.Next(0, 9), rnd.Next(0, 9), rnd.Next(5, 9), rnd.Next(5, 9));
Show2DArray(array7);
int[,] array8 = RemoveMinimumm(array7);
Show2DArray(array8);

// РЕКУРСИЯ

/*
Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
*/

void ShowNums(int n)
{
    // Проверка: можем ли мы зайти глубже
    if (n != 1) ShowNums(n--);
    // После того, как прошли все методы выше,
    // программа выводит последний результат
    Console.Write(n + " ");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);

// 5 - 1 2 3 4 5

/*
Напишите программу, которая будет принимать на вход число
и возвращать сумму его цифр.
*/

int SumOfDigits(int n)
{
    if (n != 0) return n & 10 + SumOfDigits(n / 10);
    return 0;
}

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр равна {SumOfDigits(num2)}");