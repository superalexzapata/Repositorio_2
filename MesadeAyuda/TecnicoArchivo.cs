using System.Collections;
using System.Text;

namespace MesadeAyuda
{
    public class TecnicoArchivo
    {
        public List<Tecnico> listaTecnicos;
        public void GenerarTxtTecnicos()
        {
            string rutaCompleta = @"1-Tecnicos.csv";

            var unaCadenadeTecnicos = new StringBuilder();

            // Build the users string.
            foreach (Tecnico unTecnico in listaTecnicos)
            {
                unaCadenadeTecnicos.Append(unTecnico.TipoIdentificacion);
                unaCadenadeTecnicos.Append("; No de Documento: ");
                unaCadenadeTecnicos.Append(unTecnico.NumeroIdentificacion);
                unaCadenadeTecnicos.Append("; Nombre: ");
                unaCadenadeTecnicos.Append(unTecnico.Nombre);
                unaCadenadeTecnicos.Append("; Dirección: ");
                unaCadenadeTecnicos.Append(unTecnico.Direccion);
                unaCadenadeTecnicos.Append("; Edad: ");
                unaCadenadeTecnicos.Append(unTecnico.Edad);
                unaCadenadeTecnicos.Append("; Estado: ");
                unaCadenadeTecnicos.Append(unTecnico.EsActivo);
                unaCadenadeTecnicos.Append("; No Telefonico: ");
                unaCadenadeTecnicos.Append(unTecnico.Telefono);
                unaCadenadeTecnicos.Append("; Correo: ");
                unaCadenadeTecnicos.Append(unTecnico.Email);
                unaCadenadeTecnicos.Append("; Sexo: ");
                unaCadenadeTecnicos.Append(unTecnico.Sexo);
                unaCadenadeTecnicos.Append("; Contraseña: ");
                unaCadenadeTecnicos.Append(unTecnico.Password);
                unaCadenadeTecnicos.Append("; El Grupo de Soporte es: ");
                unaCadenadeTecnicos.Append(unTecnico.GrupoSoporte.GrupoSop);
                //unaCadenadeTecnicos.Append("\n");

            }

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(unaCadenadeTecnicos.ToString());
                mylogs.Close();
            }
        }



    }
}
