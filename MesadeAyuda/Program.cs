namespace MesadeAyuda // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la Mesa de Ayuda");
            Console.WriteLine("Por favor aporte la siguiente información...");
           
            Usuario usuario = new Usuario();
            usuario.CrearUsuario();

        }


    }
}