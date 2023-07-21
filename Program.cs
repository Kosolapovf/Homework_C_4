/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


/* void f(double a)
{
Console.Write("введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
a = Math.Pow(a, b);
Console.WriteLine(a);
}
Console.Clear();
Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
f(a);
*/




/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* int f(int number)
{
int sum = 0;
while (number > 0)
{
sum = sum + number % 10;
number /= 10;
}
return sum;
}
Console.Clear();
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(number));
*/





/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
/* Console.Clear();
Console.Write("Введите количество элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numbers];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(",", array)}]"); */




/* Нужно сделать так, чтобы пользователь ввел число, которое обозначает количество элементов массива,
а потом сам в вручную ввел */