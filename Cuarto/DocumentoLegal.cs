using System;

interface Imprimible{
    void Imprimir();

        
}
interface Gabable{
    void Grabar();

        
}
abstract class MiClaseBase{
    public abstract void Imprimir();
}
class MalaOnda{
    private MalaOnda(){ //no se pueden instanciar un objeto, solo para hacer cosas estáticas

    }
    public static void Putear(){

    }
}
abstract class DocumentoLegal : MiClaseBase, Imprimible, Gabable{ // NO SE PUEDE HACER HERENCIA MULTIPLE (PARA ESO ESTAN LAS INTERFACE)
//Clase abstracta (no se puede instanciar)

    private int Numero;
    private int codEnBaseDeDatos;
    private DateTime _Fecha;
    protected int fechaAlta; //es como private pero los hijos lo pueden acceder

    // abstract public void Imprimir(); //digo que mis clases derivadas tienen que tener el metodo imprimir
    
    // virtual no es tan estricto
    // virtual public void Imprimir(){ //esto se puede hacer independiente de que sea una clase abstracta o (define un metodo pero se puede hacer override no) 
    //     Console.WriteLine("sot un DL:" + GetNumero());
    // }

    public override void Imprimir(){//este es de la clase abstracto
        Console.WriteLine("desde la clase abstracta");
    }

    void Imprimible.Imprimir(){ //este es del interface
        Console.WriteLine("desde la interface");
    }
    public void Grabar(){

    }
    public int GetNumero(){
        return Numero;
    }

    public void SetNumero(int numero){
        this.Numero = numero;
    }
    public DateTime Fecha{
        get{
            return this._Fecha;
        }
        set{
            this._Fecha = value;
        }
    }

    // o sino

    public int NumeroP{ //no se puede setear por ejemplo;
        get{
            return NumeroP;
        }
        set{}
    }
    public DocumentoLegal(int numero){ //CONSTRUCTOR  de la clase 
    //Si tengo un constructor y tengo hijos, estos hijos tmb tienen que tener constructor
        this.Numero = numero;
    }
    public void Enviar(){
        Console.WriteLine("Llamaron a DocumentoLegal.Enviar...");
    }
    private void GuardarEnBaseDeDatos(){
        Console.WriteLine("Llamaron a DocumentoLegal.GuardarEnBaseDeDatos...");
    }

    protected static void Hacer(){

    }
}

