/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int a = ReadInt("Введите число А: ");
int b = ReadInt("Введите число В: ");

int multip = a;

for(int count = 2; count <= b; count ++ )
{
    multip=multip*a;
}

Console.Write(multip);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}