namespace MesadeAyuda
{
    public class Ticket
    {
        private int Id;
        private string Titulo;
        private string Descripcion;
        private string Problema;
        public Categoria Categoria;
        public TipoSolicitud TipoSolicitud;
        public Estadistica Estadistica;
        public Prioridad Prioridad;
        public Bitacora Bitacora;
        public Usuario Usuario;
        public GrupoSoporte GrupoSoporte;

        public Ticket(Categoria categoria) /*Constructor*/
        {
            this.Categoria = categoria; /*Composición*/
        }
        public Ticket(TipoSolicitud tipoSolicitud) /*Constructor*/
        {
            this.TipoSolicitud = tipoSolicitud; /*Composición*/
        }
        public Ticket(Estadistica estadistica) /*Constructor*/
        {
            this.Estadistica = estadistica; /*Composición*/
        }
        public Ticket(Prioridad prioridad) /*Constructor*/
        {
            this.Prioridad = prioridad; /*Composición*/
        }
        public Ticket(Bitacora bitacora) /*Constructor*/
        {
            this.Bitacora = bitacora; /*Composición*/
        }
        public Ticket(Usuario usuario) /*Constructor*/
        {
            this.Usuario = usuario; /*Composición*/
        }
        public Ticket(GrupoSoporte grupoSoporte) /*Constructor*/
        {
            this.GrupoSoporte = grupoSoporte; /*Composición*/
        }

        public Ticket()
        {
        }
    }

}
