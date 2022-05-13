namespace MesadeAyuda
{
    public class Estadistica
    {
        private int Id;
        public string NombreEstadistica;
        public Array Ticket;
        public Prioridad Prioridad;

        public Estadistica(Prioridad prioridad)/*Composición*/
        {
            this.Prioridad = prioridad;
        }
        public void CrearEstadistica()/*Método*/
        {
        }

        public void ConsultarEstadistica()/*Método*/
        {
        }

        public void ActualizarPrioridad()/*Método*/
        {
        }
    }

}
