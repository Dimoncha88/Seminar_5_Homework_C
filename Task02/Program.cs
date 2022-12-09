// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размер масcива");
int n = int.Parse(Console.ReadLine());

int[] FillArray(int size)
{
    Random rnd = new Random();

    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(-99, 100);
    }
    return newArray;
}
int[] array = FillArray(n);
Console.WriteLine($"Массив: [ {string.Join(", ", array)} ]");

int FindSumOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    sum = sum + arr[i];
    return sum;
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {FindSumOddElements(array)}");