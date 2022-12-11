/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

Console.Clear();

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNumbers(num);
Console.WriteLine("Массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < num.Length; x++)
{
    if (num[x] > max)
        {
            max = num[x];
        }
    if (num[x] < min)
        {
            min = num[x];
        }
}

Console.WriteLine($"Разница между максимальным и минимальным значением: {max - min}");

void FillArrayRandomNumbers(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(1,100));
        }
}
void PrintArray(double[] num)
{
    Console.Write("[");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}