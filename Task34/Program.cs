// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 0;

while (size <= 0)
{
    Console.Write("Введите размер массива: ");
    size = int.Parse(Console.ReadLine());
}

int[] array = new int[size];
var rnd = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(100, 1000);

Console.WriteLine(String.Join(" ", array));

int even_count = 0;

foreach (int el in array)
    if (el % 2 == 0)
        even_count++;

Console.Write($"Четных чисел в массиве - {even_count}");