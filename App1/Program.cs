
using System;
using Calc.core.Interfaces;

using CalculadoraCore;
using CalcSuperPower;

namespace App1
{
    class Program
    {
        private static Icalc _calc;

        static void Main(string[] args)
        {
            _calc = new CalcSuperPower.Calcsuperpower();
            var e = new Manager(_calc);
            e.PrintSuma();
            e.PrintResta();
            e.PrintMultiplicacion();
            e.PrintDivicion();

            var a = new CalculadoraCore.Calcu();
            e.SetCalc(a);
            e.PrintSuma();
            e.PrintResta();
            e.PrintMultiplicacion();
            e.PrintDivicion();

            Console.ReadKey();


        }

    }
}