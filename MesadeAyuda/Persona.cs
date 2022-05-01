using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesadeAyuda
{
    public class Persona
    {
        private int Id;
        public enum TipoIdentificacion
        {
            cc,
            ti,
            nit,
            ce
        }

        public int NumeroIdentificacion;
        public string Nombre;
        public int Telefono;
        private string Direccion;
        private int Edad;
        private string Sexo;
        private string Email;

        private Ticket ticket;
            public Persona() /*Agregación*/
            {
                ticket = new Ticket();
            }

        public void RegistrarPersona()/*Método*/
        { 
        }

        public void ConsultarPersona()/*Método*/
        { 
        }

        public void Actualizar()/*Método*/
        { 
        }
        public void ActivarDesactivar() /*Método*/
        { 
        }
    }
}
