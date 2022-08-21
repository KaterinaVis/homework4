/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int sum = 0;
int a = Mod(number);

while(a!=0)
{
    sum = sum + a;
}
Console.WriteLine(sum);


int Mod(int num)
{
    return number%10;
}