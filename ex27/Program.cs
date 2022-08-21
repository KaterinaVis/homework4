/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int [a];

int maxindex = a-1;
int currentindex = 0;

int sum = 0;
int i = numbers[currentindex];

while(i <= numbers[maxindex])
{
    sum = sum + i;
    currentindex++;
}

Console.WriteLine(sum);