namespace MesadeAyuda
{
    public class EstadisticaArchivo
    {
        public Estadistica[] Estadistica;
        void GenerarTXT()
        {
            string rutaCompleta = @"Estadisticas.csv";
            string texto = string.Join(",", Estadistica.Select(n => n.ToString()).ToArray());
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
