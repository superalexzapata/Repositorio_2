using System.Collections;
using System.Text;

namespace MesadeAyuda
{
    public class TipoSolicitudArchivo
    {
        public List<TipoSolicitud> listaTipoSol;
        public void GenerarTxtTTiposol()
        {
            string rutaCompleta = @"6-Tipo_Solicitudes.csv";

            var unaCadenadeTipos = new StringBuilder();

            // Build the users string.
            foreach (TipoSolicitud unTipo in listaTipoSol)
            {
                unaCadenadeTipos.Append(unTipo.Id5 + ") ");
                unaCadenadeTipos.Append(unTipo.NombreSolicitud);
                unaCadenadeTipos.Append(";");
                unaCadenadeTipos.Append("\n");

            }

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(unaCadenadeTipos.ToString());
                mylogs.Close();
            }
        }
    }
}
