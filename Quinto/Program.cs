using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
// Hagan un programa que escriba en un archivo de texto un listado de personas y telefonos
// el prgrama tiene que tambien poder leer el archivo y cargarlo en una coleccion
// si modifico el archivo, tengo que poder leerlo nuevamente...


namespace Quinto
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            while(true){
                Console.WriteLine("***********MENU***********");
                Console.WriteLine("1) Nueva agenda");
                Console.WriteLine("2) Cargar agenda existente");
                Console.WriteLine("3) Exit");
                opcion = Convert.ToInt32(Console.ReadLine());

                if(opcion==1){
                    Console.Clear();
                    Console.WriteLine("Nombre de nueva agenda telefónica: ");
                    var path = Console.ReadLine();
                    var agendaNueva = new Agenda(path);

                    while(true){
                        Console.WriteLine("***********MENU***********");
                        Console.WriteLine("1) Agregar agenda existente");
                        Console.WriteLine("2) Agregar nuevo contacto");
                        Console.WriteLine("3) Eliminar contacto");
                        Console.WriteLine("4) Mostrar agenda");
                        Console.WriteLine("5) Atras");

                        opcion = Convert.ToInt32(Console.ReadLine());

                        if(opcion == 1){
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre de la agenda: ");
                            string otroPath = Console.ReadLine();

                            agendaNueva.Leer(otroPath);
                        }else if(opcion==2){
                            Console.Clear();
                            string nombre;
                            int tel;

                            Console.WriteLine("Nombre: ");
                            nombre = Console.ReadLine();

                            Console.WriteLine("Telefono: ");
                            tel = Convert.ToInt32(Console.ReadLine());

                            agendaNueva.Agregar(nombre, tel);
                        }else if(opcion==3){
                            Console.Clear();
                            string nombre;

                            Console.WriteLine("Contacto a eliminar: ");
                            nombre = Console.ReadLine();

                            agendaNueva.EliminarPorNombre(nombre);
                        }else if(opcion==4){
                            Console.Clear();
                            agendaNueva.Imprimir();
                        }else if(opcion == 5){
                            Console.Clear();
                            agendaNueva.Guardar();
                            break;
                        }

                    }
                    

                }else if(opcion==2){
                    Console.Clear();
                    Console.WriteLine("Nombre de la agenda existente: ");
                    var path = Console.ReadLine();
                    var agendaVieja = new Agenda(path);
                    agendaVieja.Leer(path);
                    while(true){
                        // Console.Clear();
                        Console.WriteLine("***********MENU***********");
                        Console.WriteLine("1) Agregar agenda existente");
                        Console.WriteLine("2) Agregar nuevo contacto");
                        Console.WriteLine("3) Eliminar contacto");
                        Console.WriteLine("4) Mostrar agenda");
                        Console.WriteLine("5) Atras");

                        opcion = Convert.ToInt32(Console.ReadLine());

                        if(opcion == 1){
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre de la agenda: ");
                            string otroPath = Console.ReadLine();

                            agendaVieja.Leer(otroPath);
                        }else if(opcion==2){
                            Console.Clear();
                            string nombre;
                            int tel;

                            Console.WriteLine("Nombre: ");
                            nombre = Console.ReadLine();

                            Console.WriteLine("Telefono: ");
                            tel = Convert.ToInt32(Console.ReadLine());

                            agendaVieja.Agregar(nombre, tel);
                        }else if(opcion==3){
                            Console.Clear();
                            string nombre;

                            Console.WriteLine("Contacto a eliminar: ");
                            nombre = Console.ReadLine();

                            agendaVieja.EliminarPorNombre(nombre);
                        }else if(opcion==4){
                            Console.Clear();
                            agendaVieja.Imprimir();
                        }else if(opcion == 5){
                            Console.Clear();
                            agendaVieja.Guardar();
                            break;
                        }
                    }

                }else if(opcion==3){
                    return;
                }
            }
            
        }
    }
}

class Agenda{

    private Dictionary<string, int> AgendaTel;
    private List<string> agenda;

    public string path;
    public Agenda(string mipath){
        this.path = mipath;
        this.AgendaTel = new Dictionary<string, int>();
    }
    public void Agregar(string nombre, int telefono){
        try{
        this.AgendaTel.Add(nombre, telefono);
        }catch{
            Console.WriteLine("No se pueden repetir los contactos");
        }
    }

    public void Guardar(){
        this.agenda = new List<string>();
        foreach(var item in AgendaTel){
            this.agenda.Add(item.Key +";"+ item.Value.ToString());
        }
        File.WriteAllLines(this.path + ".txt", this.agenda);
    }
    public void Leer(string miPath){
        try{
            string[] lines = File.ReadAllLines(miPath + ".txt");
            foreach (string line in lines){
            try{
                this.AgendaTel.Add(line.Split(';')[0],Convert.ToInt32(line.Split(';')[1]));
            }catch{
                Console.WriteLine("No se pueden repetir los contactos. Los contacto repetidos no seran agregados.");
            }
        }
        }catch{
            Console.WriteLine("No se pudo abrir el archivo.");
        }
        
    }

    public void EliminarPorNombre(string nombre){
        this.AgendaTel.Remove(nombre);
    }
    public void Imprimir(){
        foreach(var item in AgendaTel){
            Console.WriteLine("Nombre: "+ item.Key.ToString());
            Console.WriteLine("Teléfono: " + item.Value.ToString());
            Console.WriteLine("-------------------------------------");
        }
    }
}
