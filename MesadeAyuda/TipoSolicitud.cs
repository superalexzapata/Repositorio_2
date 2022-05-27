namespace MesadeAyuda
{
    public class TipoSolicitud 
    {
        private int Id;
        public string NombreSolicitud;

        public int Id5 { get => Id; set => Id = value; }

        public void CrearTipo(int tipoSolicitud)/*Método*/
        {
            Id = tipoSolicitud;
        }

        public static void ConsultarTipo()/*Método*/
        {
        }

        public static void ActualizarTipo()/*Método*/
        {
        }
    }
}
