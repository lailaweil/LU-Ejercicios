using System;

namespace Tercero
{
    class Program
    {
        static decimal Division(decimal dividendo, decimal divisor){
            //voy restandole diferenciales y sumandolos hasta que llegue a cero
            //depende cuanta presición se quiere se cambia el diferencial (hay que tener cuidado con stack overflow!)
            return (dividendo<=(decimal)0.001) ? 0: (decimal)0.001 + Division((dividendo-divisor*(decimal)0.001), divisor);

            //PROBLEMA A RESOLVER:  redondea algo mal cuando se acerca al diferencial
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
