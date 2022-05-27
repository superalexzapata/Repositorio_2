using System.Collections;
using System.Text;

namespace MesadeAyuda
{
    internal class BitacoraArchivo
    {
        public List<Bitacora> listaBitacoras;
        public void GenerarTxtBitacoras()
        {
            string rutaCompleta = @"7-Bitacoras.csv";

            var unaCadenadeBitacoras = new StringBuilder();

            // Build the users string.
            foreach (Bitacora unBitac in listaBitacoras)
            {
                //unaCadenadeBitacoras.Append(unBitac.Id);
                //unaCadenadeBitacoras.Append(";");
                unaCadenadeBitacoras.Append(unBitac.NombreBitacora);
                unaCadenadeBitacoras.Append(";");
                unaCadenadeBitacoras.Append("\n");

            }

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(unaCadenadeBitacoras.ToString());
                mylogs.Close();
            }
        }
    }
}
