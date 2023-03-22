using csharp_calcolatrice;
using System;

//SOMMA INTERI
Console.WriteLine("dammi il primo numero:");
int int1 = int.Parse(Console.ReadLine());

Console.WriteLine("dammi il secondo numero:");
int int2 = int.Parse(Console.ReadLine());

int somma = CalcoliHelper.SommaNumeriInteri(int1, int2);

Console.WriteLine($"La somma tra {int1} e {int2} è {somma}");

