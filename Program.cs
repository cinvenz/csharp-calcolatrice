using csharp_calcolatrice;
using System;

Console.WriteLine("scegli una Funzione tra 1 e 7");
var snack = Convert.ToInt32(Console.ReadLine());
switch (snack)
{
    case 1:
        somma();
        break;
    case 2:
        differenza();
        break;
    case 3:
        moltiplicazione();
        break;
    case 4:
        valoreassoluto();
        break;
    case 5:
        minimo();
        break;
    case 6:
        massimo();
        break;
    case 7:
        potenza();
        break;
   
}

//SOMMA NUMERI
void somma()
{
    Console.WriteLine("dammi il primo numero:");
    double somma1 = double.Parse(Console.ReadLine());

    Console.WriteLine("dammi il secondo numero:");
    double somma2 = double.Parse(Console.ReadLine());

    double somma = CalcoliHelper.SommaNumeri(somma1, somma2);

    Console.WriteLine($"La somma tra {somma1} e {somma2} è {somma}");
}

//DIFFERENZA NUMERI
void differenza()
{
    Console.WriteLine("dammi il primo numero:");
    double differenza1 = double.Parse(Console.ReadLine());

    Console.WriteLine("dammi il secondo numero:");
    double differenza2 = double.Parse(Console.ReadLine());

    double differenza = CalcoliHelper.DifferenzaNumeri(differenza1, differenza2);

    Console.WriteLine($"La differenza tra {differenza1} e {differenza2} è {differenza}");
}

//MOLTIPLICAZIONE NUMERI
void moltiplicazione()
{
    Console.WriteLine("dammi il primo numero:");
    double moltiplicazione1 = double.Parse(Console.ReadLine());

    Console.WriteLine("dammi il secondo numero:");
    double moltiplicazione2 = double.Parse(Console.ReadLine());

    double moltiplicazione = CalcoliHelper.MoltiplicazioneNumeri(moltiplicazione1, moltiplicazione2);

    Console.WriteLine($"La moltiplicazione tra {moltiplicazione1} e {moltiplicazione2} è {moltiplicazione}");

}

//VALORE ASSOLUTO NUMERI
void valoreassoluto()
{
    Console.WriteLine("dammi un numero:");

    double valoreassoluto1 = double.Parse(Console.ReadLine());

    double valoreassoluto = CalcoliHelper.ValoreAssoluto(valoreassoluto1);

    Console.WriteLine($"Il valore assoluto è {valoreassoluto}");

}

//MINIMO NUMERI
void minimo()
{
    Console.WriteLine("dammi il primo numero:");
    double minimo1 = double.Parse(Console.ReadLine());

    Console.WriteLine("dammi il secondo numero:");
    double minimo2 = double.Parse(Console.ReadLine());

    double minimo = CalcoliHelper.MinimoNumero(minimo1, minimo2);

    Console.WriteLine($"Il minimo tra {minimo1} e {minimo2} è {minimo}");

}

//MASSIMO NUMERI
void massimo()
{
    Console.WriteLine("dammi il primo numero:");
    double massimo1 = double.Parse(Console.ReadLine());

    Console.WriteLine("dammi il secondo numero:");
    double massimo2 = double.Parse(Console.ReadLine());

    double massimo = CalcoliHelper.MassimoNumero(massimo1, massimo2);

    Console.WriteLine($"Il massimo tra {massimo1} e {massimo2} è {massimo}");

}

//Potenza NUMERI
void potenza()
{
    Console.WriteLine("dammi il primo numero:");
    double base1 = double.Parse(Console.ReadLine());

    Console.WriteLine("dammi il secondo numero:");
    double esponente2 = double.Parse(Console.ReadLine());

    double potenza = CalcoliHelper.Potenza(base1, esponente2);

    Console.WriteLine($"l'elevamento a potenza tra base {base1} e {esponente2} è {potenza}");
}
