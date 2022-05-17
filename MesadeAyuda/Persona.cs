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
        private string Direccion;
        private int Edad;
        private enum Sexo
        {
            m,
            f
        }
        private string Email;

        private Ticket ticket;
        public Persona() /*Agregación*/
        {
            ticket = new Ticket();
        }

        public void RegistrarPersona()/*Método*/
        {
            for (int i = 0; i < Id; i++)
            {
                Id = i;
            }

            Direccion = "Calle 1";
            Edad = 21;
            var sexo = Sexo.m;
            Email = "jperez@abc.com";

            /* return las 5 variables ;*/

            Usuario usuario = Usuario();
            usuario.CrearUsuario();
           

        }

        private Usuario Usuario()
        {
            throw new NotImplementedException();
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
    }
}
