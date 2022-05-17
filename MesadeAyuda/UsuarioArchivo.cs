namespace MesadeAyuda
{
    public class UsuarioArchivo
    {
        public UsuarioArchivo[] Usuario;
        public void GenerarTXT()
        {
            string rutaCompleta = @"Usuarios.csv";
            string texto = string.Join(",", Usuario.Select(n => n.ToString()).ToArray());
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
