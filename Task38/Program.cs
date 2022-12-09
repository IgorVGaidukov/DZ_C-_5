// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 0;
var rnd = new Random();

while (size <= 0)
{
    Console.Write("Введите размер массива: ");
    size = int.Parse(Console.ReadLine());
}

int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(-99, 100);

int i_min = 0;
int i_max = 0;

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < array[i_min]) i_min = i;
    if (array[i] > array[i_max]) i_max = i;
}

Console.WriteLine(String.Join(" ", array));
Console.Write($"Разница между максимальным и минимальным элементом массива = {array[i_max]-array[i_min]}");