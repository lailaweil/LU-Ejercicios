using System;

namespace Interfaces{
    public interface ICelularBasic{
        void RecibirLlamada();
        void Llamar(string numero);

        void CargarBateria();

    }
    public interface IAgendable: ICelularBasic{
        void NuevoContacto(Contacto contacto);
        void EliminarContacto(Contacto contacto);
        void MostrarContactos();
    }
    public interface IMensajeable: IAgendable{
        void EnviarMensaje(string numero, string mensaje);
        void RecibirMensaje(string numero, string mensaje);
    }
    public interface ICelularMp3: IMensajeable{
        void Play();
        void Pausa();
        void SiguienteCancion();
        void AnteriorCancion();
    }

    public interface ICelular: ICelularMp3{
        void SacarFoto();
        void MostrarFoto();
        void GrabarVideo();
    }

    public interface ISmartphone: ICelular {
    
        void AbrirApp(string app);
        void StoreApps();
    }
}


