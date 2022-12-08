/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимально возможное значение в массиве (будет использована целая часть введенного числа)");
double min = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите максимально допустимое значение в массиве(будет использована целая часть введенного числа)");
double max = Convert.ToDouble(Console.ReadLine());

double[] Array = FillArray(size, min, max);

Console.WriteLine($"Получившийся массив: [{string.Join(", ", Array)}]");
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {ComputeDifferenceBetweenMaxAndMinValue(Array)}");

double[] FillArray(int sizeArray, double minValue, double maxValue)
{
    Random random = new Random();
    double[] resultArray = new double[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = Math.Round(random.Next((int)minValue, (int)maxValue + 1) / Math.PI, 2);
    }
    return resultArray;
}

double ComputeDifferenceBetweenMaxAndMinValue(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}
