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
            foreach (Bitacora unaBitac in listaBitacoras)
            {
                //unaCadenadeBitacoras.Append(unaBitac.Id);
                //unaCadenadeBitacoras.Append(";");
                unaCadenadeBitacoras.Append(unaBitac.NombreBitacora);
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
