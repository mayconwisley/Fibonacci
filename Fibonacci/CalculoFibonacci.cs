using System;

namespace Fibonacci
{
    class CalculoFibonacci
    {
        Int64 num1 = 1, num2 = 0, aux = 0;

        //Função normal - Resulta de cada intereção a sequencia
        public Int64 FibonacciNormal(Int64 sequencia)
        {
            if (sequencia < 2)
            {
                return sequencia;
            }
            else
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;

                return num1;
            }
        }
    }
}
