// Задача 3:
// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

void FillFloatArray(float[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    { 
        array[index] = (float) new Random().NextDouble() * 10 + (float)0.001;
        index++;
    }
}
void PrintFloatArray(float[] array)
{
    System.Console.Write("МАССИВ ВЕЩЕСТВЕННЫХ ЧИСЕЛ: ");
    for (int index = 0; index < array.Length; index++)
    {
        System.Console.Write(array[index] + " ");
    }
    System.Console.WriteLine("");
}

float[] array = new float[10];
int length = array.Length;
FillFloatArray(array);
PrintFloatArray(array);

float max = array[0];
float min = array[0];

for (int i = 1; i < 10; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

float diff = max - min;

System.Console.WriteLine("Разница между максимальным и минимальным элементом : " + diff);