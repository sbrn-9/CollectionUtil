using Calc.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.core.Interfaces;
using CalculadoraCore;
using CalcSuperPower;
namespace App1
{
    public class Manager
        {
            private Icalc _calc;

            public Manager(Icalc calc)
            {
                _calc = calc;
            }

            public void SetCalc(Icalc calc)
            {
                _calc = calc;
            }

            public void PrintSuma()
            {
                Console.WriteLine($"[App1] Suma: {_calc.Suma(1, 1)}");
            }
            public void PrintResta()
            {
                Console.WriteLine($"[App1] Resta: {_calc.Resta(3, 1)}");
            }
            public void PrintMultiplicacion()
            {
                Console.WriteLine($"[App1] Multiplicacion {_calc.Multiplicacion(2, 2)}");
            }
             public void PrintDivicion() {
                Console.WriteLine($"[App1] Division {_calc.Division(4, 4)}");
             }
    }
   }


