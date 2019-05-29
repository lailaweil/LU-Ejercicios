using System;

namespace Tercero
{
    class Program
    {
        static decimal Division(decimal dividendo, decimal divisor){
            
            if (divisor == 0)
            {
                Console.WriteLine("No se puede dividir por cero");
                throw new Exception();
            }
            //Con Decimal
            //return (dividendo<(decimal)0.1*divisor) ? 0: (decimal)0.1 + Division((dividendo-divisor*(decimal)0.1), divisor);
            //Sin Decimal
            return (dividendo < divisor) ? 0 : 1 + Division((dividendo - divisor), divisor);
        }
        static void Main(string[] args)
        {
            // Hacer una funcion División() que divida dos numeros enteros sin usar el operador /
            // una vida = iteracion
            // dos vidas = recursivo

            Console.WriteLine("Ingrese dos números a dividir: ");

            var dividendo = Convert.ToDecimal(Console.ReadLine());
            var divisor= Convert.ToDecimal(Console.ReadLine());

            var resultado = Division(dividendo,divisor);

            Console.WriteLine("El resultado de la división es: " + resultado);
            
        }
    }
}
