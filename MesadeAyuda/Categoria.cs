namespace MesadeAyuda
{
    public class Categoria
    {
        private int Id;
        public string NombreCategoria;

        public int Id2 { get => Id; set => Id = value; }

        public void CrearCategoria(int categoria)/*Método*/
        {
            Id = categoria;
        }

        public void ConsultarCategoria()/*Método*/
        {
        }

        public void ActualizarCategoria()/*Método*/
        {
        }
    }
}
