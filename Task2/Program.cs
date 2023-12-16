// Задача 2:
// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество
// чётных чисел в массиве.

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
        index++;
    }
}
void PrintArray(int[] array)
{
    System.Console.Write("МАССИВ: ");
    for (int index = 0; index < array.Length; index++)
    {
        System.Console.Write(array[index] + " ");
    }
    System.Console.WriteLine("");
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

int length = array.Length;
int evenCount = 0;

for (int i = 0; i < length; i++)
{
    if (array[i] % 2 == 0) evenCount++;
}

System.Console.WriteLine("Количество четных элементов массива : " + evenCount);
