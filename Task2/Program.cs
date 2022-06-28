﻿/*
Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Расстояние между двумя точками — это длина отрезка, 
который соединяет эти две точки. Формула. 
С помощью данной формулы можно рассчитать расстояние между двумя точками в 
пространстве: AB = √ (x b — x a) 2 + (y b — y a) 2 + (z b — z a) 2. 
Где: x a; y a; z a — координаты первой точки, 
x b; y b; z b — координаты второй точки.



*/


double Promt(string message)
{
    Console.Write(message);
    double a = double.Parse(Console.ReadLine());
    return a;
}

double x1 = Promt("Введите координату X точки A: ");
double y1 = Promt("Введите координату Y точки A: ");
double z1 = Promt("Введите координату Z точки A: ");

double x2 = Promt("Введите координату X точки B: ");
double y2 = Promt("Введите координату Y точки B: ");
double z2 = Promt("Введите координату Z точки B: ");

double x = x2 - x1;
double y = y2 - y1;
double z = z2 - z1;

Console.WriteLine($"Расстояние между точками 1 и 2 равно: {Math.Sqrt(x*x + y*y + z*z)}");

