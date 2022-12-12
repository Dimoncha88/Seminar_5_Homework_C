// Задайте одномерный массив, заполненный случайными числами. Из входного массива 
// сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
// Найдите ср. арифметическое из полученных значений элементов массивов и выведите 
// результат сравнения средних арифметических.

// [1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > 
// средн. арифм. значений элементов с нечётными числами

// [2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > 
// средн. арифм. значений элементов с чётными числами

// [1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = 
// средн. арифм. значений элементов с чётными числами

Console.Clear();
Console.WriteLine("Введите размер масcива");
int n = int.Parse(Console.ReadLine());

int[] FillArray(int size)
{
    Random rnd = new Random();

    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(1, 100);
    }
    return newArray;
}
int[] array = FillArray(n);
Console.WriteLine($"Массив: [ {string.Join(", ", array)} ]");

int[] OddArray(int[] oddArr)
{
    int[] arr1 = new int[oddArr.Length];
    int j = 0;
    for (int i = 0; i < oddArr.Length; i++)
    {
        if (oddArr[i] % 2 != 0)
        {
            arr1[j] = oddArr[i];
            j++;
        }
        else
            j = j * 1;
    }
    return arr1;
}
Console.WriteLine($"Массив с нечетными числами [ {string.Join(", ", OddArray(array))} ]");

int[] EvenArray(int[] evenArr)
{
    int[] arr2 = new int[evenArr.Length];
    int j = 0;
    for (int i = 0; i < evenArr.Length; i++)
    {
        if (evenArr[i] % 2 == 0)
        {
            arr2[j] = evenArr[i];
            j++;
        }
        else
            j = j * 1;
    }
    return arr2;
}
Console.WriteLine($"Массив с четными числами [ {string.Join(", ", EvenArray(array))} ]");

double ArithmeticMean(int[] resultArr)
{
    double sum = 0;
    for (int i = 0; i < resultArr.Length; i++){
         sum = sum + resultArr[i];
    }
        double arithsum = sum / (resultArr.Length);
    
    return arithsum;
}
Console.WriteLine($"Средн. арифм. массива значений элементов с нечётными числами =  {ArithmeticMean(OddArray(array))}");
Console.WriteLine($"Средн. арифм. массива значений элементов с чётными числами = {ArithmeticMean(EvenArray(array))}");

Console.WriteLine(ArithmeticMean(OddArray(array)) > ArithmeticMean(EvenArray(array)) ? "Cредн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами" : "Cредн. арифм. массива значений элементов с нечётными числами < средн. арифм. значений элементов с чётными числами");