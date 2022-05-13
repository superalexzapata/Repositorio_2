namespace MesadeAyuda
{
    public class SubcategoriaArchivo
    {
        public SubcategoriaArchivo[] Subcategoria;
        void GenerarTXT()
        {
            string rutaCompleta = @"Subcategorias.csv";
            string texto = string.Join(",", Subcategoria.Select(n => n.ToString()).ToArray());
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
