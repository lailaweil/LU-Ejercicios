using System;


class Factura: DocumentoLegal{
    
    public override void Imprimir(){
        if(true /*NO HAY PAPEL */){
            throw new Exception();
        }else if(true /*no hay tinta */){
            throw new Exception();
        }else if(true /*impresora apagada */){
            throw new Exception();
        }    }

    public Factura(int numero): base(numero){ //Creo el constructor padre
            
    }
    public void Pagar(){

        Hacer(); //metodo protegido y estatico de DocumentoLegal 

        Console.WriteLine("Llamaron a Facutura.Pagar...");
        // this.Enviar();
        //los private no aparecen en los hijos
        // this.fechaAlta=0;
    } 

}

class FacturaExportacion: Factura{
    public FacturaExportacion(int numero): base(numero){

    }
    //no tiene que implementar el metodo abstracot Imprimir porque ya esta implementado en Factura
    //pero... aun asi se puede
    //si Factura fuese abstracto entonces FacturaExportación tiene que si o si implementar el metodo abstracto Imprimir

    public override void Imprimir(){
        Console.WriteLine("Soy la factura de exportación: " + this.GetNumero());
    }
}
// class ListaDeFacturas{
    
//     private Factura[] lista;
//     public ListaDeFacturas(Factura[] milista){
//         this.lista = milista;
//     }

//     public int Total(){
//         int total = 0;
        
//         for(var f=0; f<lista.Length; f++){
//             total += lista[f].Monto;
//         }
//         return total;
//     }
// }