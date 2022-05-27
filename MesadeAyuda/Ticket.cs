namespace MesadeAyuda
{
    public class Ticket
    {
        private int Id;
        public string TituloFalla;
        public string DescripcionProblema;
        public Categoria Categoria;
        public TipoSolicitud TipoSolicitud;
        public Estadistica Estadistica;
        public Prioridad Prioridad;
        public Bitacora Bitacora;
        public Usuario Usuario;
        public Tecnico Tecnico;
        public GrupoSoporte GrupoSoporte;

        public int Id4 { get => Id; set => Id = value; }
        
        public Ticket(GrupoSoporte gpoSop3) /*Constructor*/
        {
            this.GrupoSoporte = gpoSop3; /*Composición*/
        }

        public Ticket(TipoSolicitud tipoSol) /*Constructor*/
        {
            this.TipoSolicitud = tipoSol; /*Composición*/
        }

        public Ticket(Categoria tipoCateg) /*Constructor*/
        {
            this.Categoria = tipoCateg; /*Composición*/
        }

        public Ticket(Estadistica nomEst) /*Constructor*/
        {
            this.Estadistica = nomEst; /*Composición*/
        }

        public Ticket(Prioridad nomPrio) /*Constructor*/
        {
            this.Prioridad = nomPrio; /*Composición*/
        }

        public Ticket(Bitacora nomBit) /*Constructor*/
        {
            this.Bitacora = nomBit; /*Composición*/
        }

        public Ticket(Usuario nomUsu) /*Constructor*/
        {
            this.Usuario = nomUsu; /*Composición*/
        }

        public Ticket(Tecnico nomTec) /*Constructor*/
        {
            this.Tecnico = nomTec; /*Composición*/
        }

        public Ticket()
        {
        }

        public void CrearTicket(int ticket) 
        {
            Id = ticket;

        }
        public static void ActualizarTicket() { }
        public static void CrearBitacora() { }
        public static void ReasignarTicket() { }

    }

}
