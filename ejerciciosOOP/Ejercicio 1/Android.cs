using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Interfaces;

namespace Android
{
    public class Android: ISmartphone{
        protected List<string> Especificaciones;
        protected string Modelo {get; set;}

        public void AbrirApp(string app)
        {
            throw new NotImplementedException();
        }

        public void AnteriorCancion()
        {
            throw new NotImplementedException();
        }

        public void CargarBateria()
        {
            throw new NotImplementedException();
        }

        public void EliminarContacto(Contacto contacto)
        {
            throw new NotImplementedException();
        }

        public void EnviarMensaje(string numero, string mensaje)
        {
            throw new NotImplementedException();
        }

        public void GrabarVideo()
        {
            throw new NotImplementedException();
        }

        public void Llamar(string numero)
        {
            throw new NotImplementedException();
        }

        public void MostrarContactos()
        {
            throw new NotImplementedException();
        }

        public void MostrarFoto()
        {
            throw new NotImplementedException();
        }

        public void NuevoContacto(Contacto contacto)
        {
            throw new NotImplementedException();
        }

        public void Pausa()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void RecibirLlamada()
        {
            throw new NotImplementedException();
        }

        public void RecibirMensaje(string numero, string mensaje)
        {
            throw new NotImplementedException();
        }

        public void SacarFoto()
        {
            throw new NotImplementedException();
        }

        public void SiguienteCancion()
        {
            throw new NotImplementedException();
        }

        public void StoreApps()
        {
            throw new NotImplementedException();
        }
    }
}