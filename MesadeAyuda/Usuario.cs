namespace MesadeAyuda
{
    public class Usuario : Persona /*Herencia*/
    {
        public string NombreUsuario;
        private string Password;
        public bool EsActivo;
        public Persona Persona;
        public Ubicacion Ubicacion;

        public Usuario(Ubicacion ubicacion) /*Composición*/
        {
            this.Ubicacion = ubicacion;
        }

        /*public override string CrearUsuario()
        {
        
        public void RegistrarPersona()
        {
            for (int i = 0; i<Id; i++)
            {
                Id = i;
            }

            Direccion = "Calle 1";
            Edad = 21;
            var sexo = Sexo.m;
            Email = "jperez@abc.com";

            

            Usuario usuario = Usuario();
            usuario.CrearUsuario();
           

        }

        }*/

        public void CrearUsuario()/*Método*/
        {
            /*recibo las 5 variables*/


            var identificacion = Persona.TipoIdentificacion.cc;
            Persona.NumeroIdentificacion = 1234;
            Persona.Nombre = "Juan Perez";
            Persona.Telefono = 8840000;
            
            /*me llevo 9 variables para la clase que genera el archivo*/
            UsuarioArchivo creador = new UsuarioArchivo();
            creador.GenerarTXT();
        }

        public void ConsultarUsuario()/*Método*/
        {
        }

        public void ActualizarUsuario()/*Método*/
        {
        }

        public void VerificarPassword()/*Método*/
        {
        }
    }
}
