// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76




Console.Clear();
Console.WriteLine("Введите размер масcива");
int n = int.Parse(Console.ReadLine());

double[] FillArray(int size)
{
    Random rnd = new Random();

    double[] newArray = new double[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(-99, 100);
    }
    return newArray;
}
double[] array = FillArray(n);
Console.WriteLine($"Массив: [ {string.Join(", ", array)} ]");

double FindDiffMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else
        if (arr[i] < min) min = arr[i];
    }
    double result = max - min;
    return result;
}
Console.WriteLine($"Разница между максимальным и минимальным элементом = {FindDiffMaxMin(array)}");