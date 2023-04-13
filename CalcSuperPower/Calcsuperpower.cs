using Calc.core.Interfaces;

namespace CalcSuperPower
{
    public class Calcsuperpower : Icalc
    {
        public int Suma(int x, int y)
        {
            return x + y +1000;
        }
        public int Resta(int x, int y)
        {
            return x - y + 1000;
        }
        public int Division(int x, int y)
        {
            return x / y + 1000;

        }
        public int Multiplicacion(int x, int y)
        {
            return x * y + 1000;
        }

    }
}