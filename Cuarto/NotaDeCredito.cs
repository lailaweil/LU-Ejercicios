using System;

class NotaDeCredito : DocumentoLegal{
 
    public NotaDeCredito(int numero): base(numero){ //Creo el constructor padre
            
    }
    public override void Imprimir(){ //sobreescribe el metodo heredaro
        Console.WriteLine("Soy la nota de crédito: " + this.GetNumero());
    }

   
    static public NotaDeCredito LeerDeBaseDeDatos(){ //método de la clase (no necestia instancia)
    //solo puede acceder a cosas que no tienen instancia (metodos y atributos estáticos)
        return new NotaDeCredito(4);
    }

}

