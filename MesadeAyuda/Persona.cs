namespace MesadeAyuda
{
    public class Persona
    {
        private int Id;
        public enum TipoIdentificacion
        {
            cc = 1,
            ti = 2,
            nit = 3,
            ce = 4
        }

        public int NumeroIdentificacion;
        public string Nombre;
        public int Telefono;
        public string Direccion;
        public int Edad;
        private string Sexo;
        public string Email;
        internal bool EsActivo;
        internal string Password;
        public Ticket ticket;

        pegue aquí

        

        public void ConsultarPersona()/*Método*/
        {
        }

        public void Actualizar()/*Método*/
        {
        }
        public void ActivarDesactivar() /*Método*/
        {
        }
    }
}
