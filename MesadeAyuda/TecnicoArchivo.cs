using System.Collections;
using System.Text;

namespace MesadeAyuda
{
    public class TecnicoArchivo
    {
        public List<Tecnico> listaTecnicos;
        public void GenerarTxtTecnicos()
        {
            string rutaCompleta = @"Tecnicos.csv";

            var unaCadenadeTecnicos = new StringBuilder();

            // Build the users string.
            foreach (Tecnico unTecnico in listaTecnicos)
            {
                unaCadenadeTecnicos.Append(unTecnico.TipoIdentificacion);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.NumeroIdentificacion);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.Nombre);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.Direccion);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.Edad);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.EsActivo);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.Telefono);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.Email);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.Sexo);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.Password);
                unaCadenadeTecnicos.Append(";");
                unaCadenadeTecnicos.Append(unTecnico.GrupoSoporte.GrupoSop);
                unaCadenadeTecnicos.Append("\n");

            }

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(unaCadenadeTecnicos.ToString());
                mylogs.Close();
            }
        }



    }
}
