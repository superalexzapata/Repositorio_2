using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesadeAyuda
{
    public class Tecnico:Persona /*Herencia*/
    {
        public string NombreTecnico;
        public GrupoSoporte GrupoSoporte;

        public Tecnico(GrupoSoporte grupoSoporte) /*Constructor*/
        {
            this.GrupoSoporte = grupoSoporte; /*Composición*/
        }

        public void CrearTecnico()/*Método*/
        {
        }

        public void ConsultarTecnico()/*Método*/
        {
        }

        public void ActualizarTecnico()/*Método*/
        {
        }
    }
}
