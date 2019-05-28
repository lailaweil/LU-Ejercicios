using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace clase_2
// Namespaces: para librerías, cuando compila se crea un solo dll(librera o assembly en C#) git si quiero tener varios módulos (o paquetes) uso varios namespaces (como se van a llamar los paquetes)

// Gac: global ASSEMBLY CACHE

{
    class Program
    {

        static void Main(string[] args)
        {

            // var doc = new DocumentoLegal(1);//no se puede instanciar una clase abstracta
            // var fac = new Factura(2);
            var nota = new NotaDeCredito(3);
            var nota2 = new NotaDeCredito(4);
            var facexp = new FacturaExportacion(1);

            nota.SetNumero(1);
            nota2.SetNumero(2);

            // doc.Enviar();

            // fac.Enviar();
            // fac.Pagar();

            // bool si = (doc is DocumentoLegal); //true
            // si = (fac is DocumentoLegal); //true
            // si = (fac is Factura); //true

            // HacerAlgoConDocumetos(doc);
            // HacerAlgoConDocumetos(fac);
            HacerAlgoConDocumetos(nota);
            HacerAlgoConDocumetos(nota2);
            HacerAlgoConDocumetos(facexp);

            var nnc = NotaDeCredito.LeerDeBaseDeDatos(); //uso de método estático (de clase)
            // NotaDeCredito prueba = null; //una variable puede apuntar a un objeto o no apuntar.MALA PRÁCTICA

            object algo = (DocumentoLegal) facexp; // object puede apuntar a cualquier cosa
            algo = 3;
            
            var facturas = new Factura[3];
            facturas[0] = new Factura(1);
            facturas[1] = new Factura(2);
            facturas[2] = new Factura(3);

            // ListaDeFacturas listaF = new ListaDeFacturas(facturas);
            // listaF.Total();

            var lista= new List<Factura>(); //clase genérica que ya viene por default
            lista.Sort(new ComparadorMontoDL());
            var dic = new Dictionary<string, Factura>();
            dic.Add("lagash", new Factura(1));
            var fact = dic["lagash"];

            // try{
            //     facexp.Imprimir();
            // }catch{ //agarra cualquier error no importa cual
            //     Console.WriteLine("reporteError@teletubies.com")
            // }
            try{
                facexp.Imprimir();
            }catch(NoHayPapelExcepcion){ //agarra cualquier error no importa cual
                Console.WriteLine("Compra papel");
            }catch{
                Console.WriteLine("segui participando!");
            }
            // prueba.Imprimir(); //me deja pero es un error 
            // HacerAlgoConDocumetos(prueba); //ERROR: porque es de ese tipo pero apunta a null 


        }

        static void HacerAlgoConDocumetos(DocumentoLegal doc){

            if(doc is Factura){
                doc.Imprimir();
            }else if(doc is NotaDeCredito){
                doc.Imprimir();
            }
        }
    }
}

class ComparadorMontoDL : IComparer<DocumentoLegal> //implemento una interfaz con un metodo para comparar un objeto y yo decido como lo hago
{
    public int Compare(DocumentoLegal x, DocumentoLegal y)
    {
        //ejemplo; comparo por monto
        if(x.Monto > y.Monto) return -1;
        if(x.Monto < y.Monto) return 1;
        return 0;
    }
}
class NoHayPapelExcepcion : Exception{

}