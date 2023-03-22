using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//-Somma di due numeri interi ----------------------
//- Somma di due numeri double --------------------
//- Differenza tra due numeri interi ---------------
//- Differenza tra due numeri double ------------------
//- Moltiplicazione di due numeri interi ----------------
//- Moltiplicazione di due numeri double -----------------
//- Valore assoluto di un numero intero ------------------
//- Valore assoluto di un numero double -------------------
//- Minimo tra due numeri interi ------------------------
//- Minimo tra due numeri double ------------------------ 
//- Massimo tra due numeri interi ------------------------
//- Massimo tra due numeri double -------------------------

namespace csharp_calcolatrice
{
    internal class CalcoliHelper
    {
        public static int SommaNumeriInteri(int int1, int int2) => int1 + int2;
        public static double SommaNumeriDouble(double double1, double double2) => double1 + double2;
        public static int DifferenzaNumeriInteri(int int1, int int2) => int1 - int2;
        public static double DifferenzaNumeriDouble(double double1, double double2) => double1 - double2;
        public static int MoltiplicazioneNumeriInteri(int int1, int int2) => int1 * int2;
        public static double MoltiplicazioneNumeriDouble(double double1, double double2) => double1 * double2;
        public static int ValoreAssolutoIntero(int int1)
        {
            {
                if (int1 < 0)
                {
                    return -int1;
                }
                else
                {
                    return int1;
                }
            }
        }
        public static double ValoreAssolutoDouble(double double1)
        {
            {
                if (double1 < 0)
                {
                    return -double1;
                }
                else
                {
                    return double1;
                }
            }
        }

        public static int MinimoNumeroInteri(int int1, int int2)
        {
            {
                if (int1 < int2)
                {
                    return int1;
                }
                else if (int2 < int1)
                {
                    return int2;
                }
                else int1 = int2;
                {
                    return int1;
                }
            }
        }

        public static double MinimoNumeroDouble(double double1, double double2)
        {
            {
                if (double1 < double2)
                {
                    return double1;
                }
                else
                {
                    return double2;
                }
            }
        }

        public static int MassimoNumeroInteri(int int1, int int2)
        {
            {
                if (int1 < int2)
                {
                    return int2;
                }
                else
                {
                    return int1;
                }
            }
        }

        public static double MassimoNumeroDouble(double double1, double double2)
        {
            {
                if (double1 < double2)
                {
                    return double2;
                }
                else
                {
                    return double1;
                }
            }
        }
    }
}
