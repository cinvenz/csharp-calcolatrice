﻿using csharp_calcolatrice;
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

Console.WriteLine($"il valore assoluto è {valoreassoluto}");