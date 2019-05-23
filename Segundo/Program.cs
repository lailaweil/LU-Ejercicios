using System;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un array de 10 posiciones
            //imprimir la suma de las 10 posiciones
            //Si es dibisible por 3, mencionarlo
            int cantidad = 10;
            int[] numeros = new int[cantidad];
            int suma = 0;

            Console.Write("Ingrese 10 numeros: ");

            for(int i = 0; i < cantidad; i++ ){
                
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

            if(0 == (suma % 3) && suma != 0){
                Console.WriteLine("La suma total es: " + suma + " y es divisible por 3.");
            }else{
                Console.WriteLine("La suma total es: " + suma);
            }
            
        }
    }
}
