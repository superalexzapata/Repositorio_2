using System.Collections;
using System.Text;

namespace MesadeAyuda
{
    public class UsuarioArchivo
    {
        public List<Usuario> listaUsuarios;
        public void GenerarTxtUsuarios()
        {
            string rutaCompleta = @"2-Usuarios.csv";

            var unaCadenadeUsuarios = new StringBuilder();

            // Build the users string.
            foreach (Usuario unUsuario in listaUsuarios)
            {
                //unaCadenadeUsuarios.Append(unUsuario.id);
                //unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.TipoIdentificacion);
                unaCadenadeUsuarios.Append("; No de Documento: ");
                unaCadenadeUsuarios.Append(unUsuario.NumeroIdentificacion);
                unaCadenadeUsuarios.Append("; Nombre: ");
                unaCadenadeUsuarios.Append(unUsuario.Nombre);
                unaCadenadeUsuarios.Append("; Dirección: ");
                unaCadenadeUsuarios.Append(unUsuario.Direccion);
                unaCadenadeUsuarios.Append("; Edad: ");
                unaCadenadeUsuarios.Append(unUsuario.Edad);
                unaCadenadeUsuarios.Append("; Estado: ");
                unaCadenadeUsuarios.Append(unUsuario.EsActivo);
                unaCadenadeUsuarios.Append("; No Telefonico: ");
                unaCadenadeUsuarios.Append(unUsuario.Telefono);
                unaCadenadeUsuarios.Append("; Correo: ");
                unaCadenadeUsuarios.Append(unUsuario.Email);
                unaCadenadeUsuarios.Append("; Sexo: ");
                unaCadenadeUsuarios.Append(unUsuario.Sexo);
                unaCadenadeUsuarios.Append("; Contraseña: ");
                unaCadenadeUsuarios.Append(unUsuario.Password);
                unaCadenadeUsuarios.Append("; Ubicación a la que pertenece: ");
                unaCadenadeUsuarios.Append(unUsuario.UbicacionUsuario.NombreUbicacion);
                //unaCadenadeUsuarios.Append("\n");

            }

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(unaCadenadeUsuarios.ToString());
                mylogs.Close();
            }



        }
    }
}
