
/* Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
 Напишите программу, которая покажет количество четных чисел в массиве.*/

Console.Clear();

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Массив: ");
PrintArray(num);
int count = 0;

for (int x = 0; x < num.Length; x++)
if (num[x] % 2 == 0)
count++;

Console.WriteLine($"Всего {count} чётных числа");

void FillArrayRandomNumbers(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}