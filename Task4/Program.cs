// Задача 4**(не обязательно):
// Дано натуральное число в диапазоне от 1 до 100 000.
// Создайте массив, состоящий из цифр этого числа.
// Старший разряд числа должен располагаться на 0-м индексе массива,
// младший – на последнем.
// Размер массива должен быть равен количеству цифр.

int genNum(int min, int max)
{
    int val = new Random().Next(min, max);
    return val;
}

int val = genNum(1,100000);
System.Console.WriteLine("val = " + val);

int len = 0;
int ten = 1;
int var = val;

while (var > 0)
{
    var /= 10;
    ten *=10;
    len++;
}
ten = ten/10;

int[] array = new int[len];
var = val;
for(int i = 0; i < len; i++)
{
    //array[i] = var - ten *(var / ten);
    array[i] = var / ten;
    System.Console.Write(array[i] + " ");
    var = var - array[i]*ten;
    ten = ten/10; 
}

System.Console.WriteLine("");
