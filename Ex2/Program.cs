/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);
int count = 0;
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += numbers[i];
    }
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}