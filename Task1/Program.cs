// Задача 1:
// Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [20,90].

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
int length = array.Length;
FillArray(array);
PrintArray(array);

int count = 0;
for (int i = 0; i < 10; i++)
{
    if (array[i] >= 20 && array[i] <= 90) count++;
}

System.Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20,90] : " + count);