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

        public void CrearUsuario()/*Método*/
        {

            /*for (int i = 0; i > Id; i++) 
            {

            }*/


            Console.WriteLine("Digite el tipo de identificación (cc - ti - nit - ce): ");
            Persona.TipoIdentificacion = Console.ReadLine();

            if (Persona.TipoIdentificacion == TipoIdentificacion.cc)
            {
                Persona.TipoIdentificacion = Console.ReadLine();
            }
            else if (Persona.TipoIdentificacion == TipoIdentificacion.ti)
            {
                Persona.TipoIdentificacion = Console.ReadLine();
            }
            else if (Persona.TipoIdentificacion == TipoIdentificacion.nit)
            {
                Persona.TipoIdentificacion = Console.ReadLine();
            }
            else if (Persona.TipoIdentificacion == TipoIdentificacion.ce)
            {
                Persona.TipoIdentificacion = Console.ReadLine();
            }


            Console.WriteLine("Digite su número de indentificación: ");
            NumeroIdentificacion = Console.ReadLine();

            Console.WriteLine("Digite su nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Digite su dirección: ");
            Direccion = Console.ReadLine();

            Console.WriteLine("Digite su teléfono: ");
            Telefono = Console.ReadLine();

            Console.WriteLine("Digite su edad: ");
            Edad = Console.ReadLine();

            Console.WriteLine("Cuál es su sexo (M - F): ");
            if (Sexo == Sexo.m)
            {
                Sexo = Sexo.m;
            }
            else if (Sexo == Sexo.f)
            {
                Sexo = Sexo.f;
            }

            Console.WriteLine("Digite su correo electrónico: ");
            Email = Console.ReadLine();

            Persona.GenerarTXT();
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
