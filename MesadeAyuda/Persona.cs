namespace MesadeAyuda
{
    public class Persona
    {
        private int Id;
        public string TipoIdentificacion;
        public int NumeroIdentificacion;
        public string Nombre;
        public int Telefono;
        public string Direccion;
        public int Edad;
        public string Sexo;
        public string Email;
        internal bool EsActivo;
        internal string Password;
        public Ticket ticket;

        public Persona() /*Agregación*/
        {
            ticket = new Ticket();
        }

        public void RegistrarPersona(int id)/*Método*/
        {
            Id = id;
        }



        public void ConsultarPersona()/*Método*/
        {
        }

        public void Actualizar()/*Método*/
        {
        }
        public void ActivarDesactivar() /*Método*/
        {
        }
