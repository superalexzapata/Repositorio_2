using System.Collections;
using System.Text;

namespace MesadeAyuda
{
    public class UsuarioArchivo
    {
        public List<Usuario> listaUsuarios;
        public void GenerarTxtUsuarios()
        {
            string rutaCompleta = @"Usuarios.csv";

            var unaCadenadeUsuarios = new StringBuilder();

            // Build the users string.
            foreach (Usuario unUsuario in listaUsuarios)
            {
                //unaCadenadeUsuarios.Append(unUsuario.id);
                //unaCadenadeUsuarios.Append(";");
                //unaCadenadeUsuarios.Append(unUsuario.tipoDoc);
                //unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.NumeroIdentificacion);
                unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.Nombre);
                unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.Direccion);
                unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.Edad);
                unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.EsActivo);
                unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.Telefono);
                unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.Email);
                unaCadenadeUsuarios.Append(";");
                //unaCadenadeUsuarios.Append(unUsuario.Sexo);
                //unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.Password);
                unaCadenadeUsuarios.Append(";");
                unaCadenadeUsuarios.Append(unUsuario.UbicacionUsuario.NombreUbicacion);
                unaCadenadeUsuarios.Append("\n");

            }

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(unaCadenadeUsuarios.ToString());
                mylogs.Close();
            }



        }
    }
}
