using csharp_calcolatrice;
using System;

//SOMMA NUMERI
Console.WriteLine("dammi il primo numero:");
double somma1 = double.Parse(Console.ReadLine());

Console.WriteLine("dammi il secondo numero:");
double somma2 = double.Parse(Console.ReadLine());

double somma = CalcoliHelper.SommaNumeri(somma1, somma2);

Console.WriteLine($"La somma tra {somma1} e {somma2} è {somma}");

//DIFFERENZA NUMERI
Console.WriteLine("dammi il primo numero:");
double differenza1 = double.Parse(Console.ReadLine());

Console.WriteLine("dammi il secondo numero:");
double differenza2 = double.Parse(Console.ReadLine());

double differenza = CalcoliHelper.DifferenzaNumeri(differenza1, differenza2);

Console.WriteLine($"La differenza tra {differenza1} e {differenza2} è {differenza}");

//MOLTIPLICAZIONE NUMERI
Console.WriteLine("dammi il primo numero:");
double moltiplicazione1 = double.Parse(Console.ReadLine());

Console.WriteLine("dammi il secondo numero:");
double moltiplicazione2 = double.Parse(Console.ReadLine());

double moltiplicazione = CalcoliHelper.MoltiplicazioneNumeri(moltiplicazione1, moltiplicazione2);

Console.WriteLine($"La moltiplicazione tra {moltiplicazione1} e {moltiplicazione2} è {differenza}");

//VALORE ASSOLUTO NUMERI
Console.WriteLine("dammi un numero:");

double valoreassoluto1 = double.Parse(Console.ReadLine());

double valoreassoluto = CalcoliHelper.ValoreAssoluto(valoreassoluto1);

Console.WriteLine($"Il valore assoluto è {valoreassoluto}");

//MINIMO NUMERI
Console.WriteLine("dammi il primo numero:");
double minimo1 = double.Parse(Console.ReadLine());

Console.WriteLine("dammi il secondo numero:");
double minimo2 = double.Parse(Console.ReadLine());

double minimo = CalcoliHelper.MinimoNumero(minimo1, minimo2);

Console.WriteLine($"Il minimo tra {minimo1} e {minimo2} è {minimo}");

//MASSIMO NUMERI
Console.WriteLine("dammi il primo numero:");
double massimo1 = double.Parse(Console.ReadLine());

Console.WriteLine("dammi il secondo numero:");
double massimo2 = double.Parse(Console.ReadLine());

double massimo = CalcoliHelper.MinimoNumero(massimo1, massimo2);

Console.WriteLine($"Il massimo tra {massimo1} e {massimo2} è {massimo}");

