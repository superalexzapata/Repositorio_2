using System.Collections;
using System.Text;

namespace MesadeAyuda
{
    public class EstadisticaArchivo
    {
        public List<Estadistica> listaEstadisticas;
        public void GenerarTxtEstadisticas()
        {
            string rutaCompleta = @"5Estadisticas.csv";

            var unaCadenadeEstadisticas = new StringBuilder();

            // Build the users string.
            foreach (Estadistica unEstad in listaEstadisticas)
            {
                //unaCadenadeEstadisticas.Append(unTipo.Id);
                //unaCadenadeEstadisticas.Append(";");
                unaCadenadeEstadisticas.Append(unEstad.NombreEstadistica);
                unaCadenadeEstadisticas.Append(";");
                unaCadenadeEstadisticas.Append("\n");

            }

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(unaCadenadeEstadisticas.ToString());
                mylogs.Close();
            }
        }

    }
}
