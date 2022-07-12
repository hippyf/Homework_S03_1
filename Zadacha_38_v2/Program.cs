/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
Zadacha_38();

void Zadacha_38()
{
    Random random = new Random();
    int size = random.Next(4, 15);
    double [] array = new double [size];
    FillArray(array);
    PrintArray(array);
    DifMaxMinElement(array);
}

void FillArray (double [] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.Next(-1000, 1001) * random.NextDouble(),2);
    }
}

void PrintArray (double [] array)
{
    Console.WriteLine();
    Console.Write("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}
void DifMaxMinElement (double [] array)
{
    int maxPosition = 0;
    int minPosition = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxPosition]) maxPosition = i;
    }
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minPosition]) minPosition = i;
    }
    Console.WriteLine();
    Console.WriteLine("Максимальный элемент равен " + array[maxPosition]);
    Console.WriteLine("Минимальный элемент равен " + array[minPosition]);
    Console.WriteLine();
    Console.WriteLine("Разница между максимальным и минимальным элементами массива равна " + (array[maxPosition] - array[minPosition]));
    Console.WriteLine();
}   