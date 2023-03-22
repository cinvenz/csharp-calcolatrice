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
        public static int SommaNumeri(int int1, int int2)
        {
            return int1 + int2;
        }

        public static double SommaNumeri(double double1, double double2)
        {
            return double1 + double2;
        }

        public static int DifferenzaNumeri(int int1, int int2)
        {
            return int1 - int2;
        }

        public static double DifferenzaNumeri(double double1, double double2)
        {
            return double1 - double2;
        }

        public static int MoltiplicazioneNumeri(int int1, int int2)
        {
            return int1 * int2;
        }

        public static double MoltiplicazioneNumeri(double double1, double double2)
        {
            return double1 * double2;
        }
        
        public static int ValoreAssoluto(int int1)
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
        public static double ValoreAssoluto(double double1)
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

        public static int MinimoNumero(int int1, int int2)
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
                else 
                {
                    return 404;
                }
            }
        }

        public static double MinimoNumero(double double1, double double2)
        {
            {
                if (double1 < double2)
                {
                    return double1;
                }
                else if (double2 < double1)
                {
                    return double2;
                }
                else;
                {
                    return 404;
                }
            }
        }

        public static int MassimoNumero(int int1, int int2)
        {
            {
                if (int1 < int2)
                {
                    return int2;
                }
                else if (int2 < int1)
                {
                    return int1;
                }
                else 
                {
                    return 404;
                }
            }
        }

        public static double MassimoNumero(double double1, double double2)
        {
            {
                if (double1 < double2)
                {
                    return double2;
                }
                else if (double2 < double1)
                {
                    return double1;
                }
                else
                {
                    return 404;
                }
            }
        }
    }
}
