namespace MesadeAyuda
{
    public class Ticket
    {
        private int Id;
        private string TituloFalla;
        private string DescripcionProblema;
        private string Problema;
        public Categoria Categoria;
        public TipoSolicitud TipoSolicitud;
        public Estadistica Estadistica;
        public Prioridad Prioridad;
        public Bitacora Bitacora;
        public Usuario Usuario;
        public Tecnico Tecnico;
        public GrupoSoporte GrupoSoporte;

        pegue aquí

        public void CrearTicket(int ticket, string tituloFalla, string descripcion) 
        {
            Id = ticket;
            TituloFalla = tituloFalla;
            DescripcionProblema = descripcion;
        }

    }

}
