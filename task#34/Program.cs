/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] Array = FillArray(size);

Console.WriteLine($"Получившийся массив: [{string.Join(",", Array)}]");
Console.WriteLine($"Количество четных элементов массива равно {CountEvenNumbers(Array)}");

int[] FillArray(int sizeArray)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(100, 1000);
    }
    return resultArray;
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            count++;
        } 
    }
    return count;
}