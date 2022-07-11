/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */ 

Zadacha_34();

void Zadacha_34()
{
    Random random = new Random();
    int size = random.Next(4, 15);
    int [] array = new int [size];
    FillArray(array);
    PrintArray(array);
    CountEvenNumbers(array);
}

void FillArray (int [] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
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
void CountEvenNumbers (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count += 1;
        } 
    }
    Console.WriteLine("Количество четных чисел в массиве равно " + count);
    Console.WriteLine();
}   