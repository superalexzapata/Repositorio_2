using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesadeAyuda
{
    public class SubCategoria
    {

        private int IdSubCategoria;
        private string NombreSubCategoria;
        public Categoria Categoria;

        public SubCategoria(Categoria categoria)/*Composición*/
        {
            this.Categoria = categoria;
        }
        public void CrearSubCategoria()/*Método*/
        {
        }

        public void ConsultarSubCategoria()/*Método*/
        {
        }

        public void ActualizarSubCategoria()/*Método*/
        {
        }
    }

}
