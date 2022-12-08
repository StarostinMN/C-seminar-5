/* Дополнительная задача (задача со звёздочкой): Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.

[1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами

[2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами

[1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами */

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
int[] EvenArray = FormArrayWithEvenNum(array);
int[] OddArray = FormArrayWithOddNum(array);

Console.WriteLine($"Сгенерированный массив: [{string.Join(",", array)}]");
Console.WriteLine($"Массив четных чисел: [{string.Join(",", EvenArray)}]");
Console.WriteLine($"Среднее арифметическое элементов массива четных чисел равно: {ComputeAverage(EvenArray)}");
Console.WriteLine($"Массив нечетных чисел: [{string.Join(",", OddArray)}]");
Console.WriteLine($"Среднее арифметическое элементов массива нечетных чисел равно: {ComputeAverage(OddArray)}");
if (ComputeAverage(EvenArray) > ComputeAverage(OddArray))
{
    Console.WriteLine("Средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами");
}
else if (ComputeAverage(OddArray) > ComputeAverage(EvenArray))
{
    Console.WriteLine("Средн. арифм. значений элементов массива с нечётными числами > средн. арифм. значений элементов с чётными числами");
}
else
{
    Console.WriteLine("Средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами");
}

//Console.WriteLine($"Массив четных элементов {FormArrayWithEvenElements(array)}");
//Console.WriteLine($"Сумма отрицательных элементов в массиве: {FormArrayWithEvenElements(array)}");


int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] FormArrayWithEvenNum(int[] InputArray)
{
    size = InputArray.Length;
    int SizeOfEvenNumArray = 0;
    for (int i = 0; i < size; i++)
    {
        if (InputArray[i] % 2 == 0) SizeOfEvenNumArray++;
    }
    int[] EvenNumArray = new int[SizeOfEvenNumArray];
    int index = 0;
    for (int i = 0; i < size; i++)
    {
        if (InputArray[i] % 2 == 0)
        {
            EvenNumArray[index] = InputArray[i];
            index++;
        }
    }
    return EvenNumArray;
}

int[] FormArrayWithOddNum(int[] InputArray)
{
    size = InputArray.Length;
    int SizeOfOddNumArray = 0;
    for (int i = 0; i < size; i++)
    {
        if (InputArray[i] % 2 == 1) SizeOfOddNumArray++;
    }
    int[] OddNumArray = new int[SizeOfOddNumArray];
    int index = 0;
    for (int i = 0; i < size; i++)
    {
        if (InputArray[i] % 2 == 1)
        {
            OddNumArray[index] = InputArray[i];
            index++;
        }
    }
    return OddNumArray;
}

double ComputeAverage(int[] inputArray)
{
    int sum = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        sum = sum + inputArray[i];
    }
    double average = (double)(sum / inputArray.Length);
    return average;
}

