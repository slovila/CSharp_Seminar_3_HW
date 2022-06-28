/*
Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27. 
5 -> 1, 8, 27, 64, 125
*/

System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int count = 1; count <= N; count++)
{
    System.Console.Write(Math.Pow(count, 3) + " ");
}
