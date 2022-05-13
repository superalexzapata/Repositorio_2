namespace MesadeAyuda
{
    public class PersonaArchivo
    {
        public Persona[] Persona;
        void GenerarTXT()
        {
            string rutaCompleta = @"Personas.csv";
            string texto = string.Join(",", Persona.Select(n => n.ToString()).ToArray());
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
