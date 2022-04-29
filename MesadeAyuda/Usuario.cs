using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesadeAyuda
{
    public class Usuario: Persona /*Herencia*/
    {
        public string NombreUsuario;
        private string Password;
        public bool EsActivo;
        public Persona Persona;
        public Ubicacion Ubicacion;

        public void CrearUsuario()/*Método*/
        { 
        }

        public void ConsultarUsuario()/*Método*/
        {
        }

        public void ActualizarUsuario()/*Método*/
        {
        }

        public void VerificarPassword()/*Método*/
        {
        }
    }
}
