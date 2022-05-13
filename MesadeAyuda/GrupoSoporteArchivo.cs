namespace MesadeAyuda
{
    public class GrupoSoporteArchivo
    {
        public GrupoSoporte[] GrupoSoporte;
        void GenerarTXT()
        {
            string rutaCompleta = @"GruposSoporte.csv";
            string texto = string.Join(",", GrupoSoporte.Select(n => n.ToString()).ToArray());
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
