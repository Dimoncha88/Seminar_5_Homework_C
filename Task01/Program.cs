// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите число элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size);

Console.WriteLine($"Массив: [ {string.Join(", ", array)} ]");

int[] FillArray(int sizeArray)
{
    Random rnd = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(100, 1000);
    }
    return resultArray;
}

int FindQuantityEvenNumbers(int[] sizeArray)
{
    int count = 0;
    for (int i = 0; i < sizeArray.Length; i++)
        if (sizeArray[i] % 2 == 0) count++;
    return count;
}
Console.WriteLine($"Количество четных чисел в массиве: {FindQuantityEvenNumbers(array)}");