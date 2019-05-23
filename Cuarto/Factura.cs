using System;


abstract class Factura: DocumentoLegal{
    
    // public override void Imprimir(){
    //     Console.WriteLine("Soy la factura: " + this.GetNumero());
    // }

    
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