using System;

namespace Tercero
{
    class Program
    {
        static decimal Division(decimal dividendo, decimal divisor){
            //voy restandole diferenciales y sumandolos hasta que llegue a cero
            //depende cuanta presición se quiere se cambia el diferencial (hay que tener cuidado con stack overflow!)
            return (dividendo<=0) ? 0: (decimal)0.01 + Division((dividendo-divisor*(decimal)0.01), divisor);

            //PROBLEMA A RESOLVER: redondea para arriba (Ej, 1/3 es 0.333 y nos da 0.34)
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
