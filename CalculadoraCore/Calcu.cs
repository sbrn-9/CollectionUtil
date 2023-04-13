using Calc.core.Interfaces;

namespace CalculadoraCore
{
    public class Calcu: Icalc
    {
        public int Suma(int x, int y)
        {
            return x + y;
        }
        public int Resta(int x, int y)
        {
            return x - y;
        }
        public int Division(int x , int y)
        {
            return x / y;
        }
        public int Multiplicacion(int x , int y)
        {
            return x * y;
        }
    }
}