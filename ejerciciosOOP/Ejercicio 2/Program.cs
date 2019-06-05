using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fifo = new Fifo<int>();

            while(true){
                Console.WriteLine("1) Add item");
                Console.WriteLine("2) Get item");
                Console.WriteLine("3) Delete item");
                Console.WriteLine("4) Show the number of item");
                Console.WriteLine("5) Show min and max item");
                Console.WriteLine("6) Find an item");
                Console.WriteLine("7) Print all item");
                Console.WriteLine("8) Exit");

                var opcion = Console.ReadLine();

                switch (opcion)
                {   
                    case "1":
                        Console.WriteLine("Elemento a agregar: ");
                        fifo.Add(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case "2":
                        var item = fifo.Get();
                        Console.WriteLine(item);
                        break;
                    case "3":
                        Console.WriteLine("Elemento a eliminar: ");
                        fifo.Delete(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "4":
                        Console.WriteLine(fifo.GetLength());
                        break;
                    case "5":
                        Console.WriteLine("El item menor es: " + fifo.GetMin());
                        Console.WriteLine("El item mayor es: " + fifo.GetMax());
                        break;
                    case "6":
                        Console.WriteLine("Elige el indice del item a buscar: ");
                        var indice = Convert.ToInt32(Console.ReadLine());
                        var t = fifo.Find(indice);
                        Console.WriteLine("El item en el indice " + indice + " es " + t);
                        break;
                    case "7":
                        fifo.PrintAll();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Opcion no valida!");
                        break;
                }
            }
        }
    }
}
