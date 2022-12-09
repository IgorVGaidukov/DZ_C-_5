// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 0;

while (size <= 0)
{
    Console.Write("Введите размер массива: ");
    size = int.Parse(Console.ReadLine());
}

int[] array = new int[size];
var rnd = new Random();
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-99, 100);
    if (i % 2 == 1)
        sum += array[i];
}

Console.WriteLine(String.Join(" ", array));
Console.Write($"Сумма элементов на нечетных позициях = {sum}");