using System;

namespace Primero
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo = 155;
            int empleados= 0;
            int transferencia;
            int[] sueldos = new int[5];
            bool CuentaHecha = false;

            Console.Write("Cantidad de empleados: ");
            empleados = Convert.ToInt32(Console.ReadLine());

            transferencia = sueldo * empleados;
            // sueldos[0]=100;
            // sueldos[1]=200;
            CuentaHecha = true;
            
            if(CuentaHecha){
                if((transferencia % 2) == 0){
                    Console.WriteLine("La tranferencia es de: " + transferencia + " y es par");
                }else{
                    Console.WriteLine("La tranferencia es de: " + transferencia + " y es impar");
                }
            }else{
                Console.WriteLine("Error! No se pudo hacer la transferencia");
            }
            
        }
    }
}
