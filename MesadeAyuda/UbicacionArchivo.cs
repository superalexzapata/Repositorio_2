namespace MesadeAyuda
{
    public class UbicacionArchivo
    {
        public UbicacionArchivo[] Ubicacion;
        void GenerarTXT()
        {
            string rutaCompleta = @"Ubicaciones.csv";
            string texto = string.Join(",", Ubicacion.Select(n => n.ToString()).ToArray());
            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string strDate = Convert.ToDateTime(dateTime).ToString("yyMMdd");
                mylogs.WriteLine(texto + strDate);
                mylogs.Close();
            }
        }
    }
}
