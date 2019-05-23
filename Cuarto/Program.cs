using System;

namespace clase_2
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
            NotaDeCredito prueba = null; //una variable puede apuntar a un objeto o no apuntar.MALA PRÁCTICA



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