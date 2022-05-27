namespace MesadeAyuda
{
    public class Estadistica
    {
        private int Id;
        public string NombreEstadistica;

        public int Id3 { get => Id; set => Id = value; }

        public void CrearEstadistica(int estad)/*Método*/
        {
            Id = estad;
        }

        public void ConsultarEstadistica()/*Método*/
        {
        }

        public void ActualizarPrioridad()/*Método*/
        {
        }
    }

}
