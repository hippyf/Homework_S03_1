/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */ 

Zadacha_36();

void Zadacha_36()
{
    Random random = new Random();
    int size = random.Next(4, 8);
    int [] array = new int [size];
    FillArray(array);
    PrintArray(array);
    SumUnevenPositionElements(array);
}

void FillArray (int [] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 1000);
    }
}

void PrintArray (int [] array)
{
    Console.WriteLine();
    Console.Write("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}
void SumUnevenPositionElements (int [] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        count += array[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях, равна " + count);
    Console.WriteLine();
}   