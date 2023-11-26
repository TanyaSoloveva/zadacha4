// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр

Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");
int number = int.Parse(Console.ReadLine());
int size = (int)Math.Log10(number) + 1;
Console.WriteLine($"Размер массива: {size}"); //вывод размера полученноего массива
string s = Convert.ToString(number);
List<int> list = new List<int>();
char[] arr = s.ToCharArray();
for (int i = 0; i < arr.Length; i++)
{
    list.Add(Int32.Parse(new String(arr[i], 1)));
    Console.WriteLine(list[i] + "\t"); // вывод полученного массива из цифер числа
}

int min = list[0];
int max = list[0];
int minInd = 0;
int maxInd = 0;

for (int i = 0; i != size; i++)
{
    if (list[i] > max)
    {
        max = list[i];
        maxInd = i; // поиск максимума
    }
    if (list[i] < min)
    {
        min = list[i];
        minInd = i; // поиск минимума
    }
}
int[] list2 = new int[size]; // создание нового массива, куда перезапишу данные

list2[0] = list[maxInd]; // перемещение максимума в начало
list2[size-1] = list[minInd]; // перемещение минимума в конец
int z = 0;
for (int i = 0; i != size; i++) // смещение остальных элементов массива
{
    if (i == maxInd || i == minInd) { z++; }
    else list2[i + 1 - z] = list[i];
}
Console.WriteLine(String.Join(" ", list2)); // вывод полученого массива
// Возникает предупреждение не могу понять о чем