﻿namespace MesadeAyuda
{
    public class TipoSolicitudArchivo
    {
        public TipoSolicitud[] TipoSolicitud;
        void GenerarTXT()
        {
            string rutaCompleta = @"TipoSolicitudes.csv";
            string texto = string.Join(",", TipoSolicitud.Select(n => n.ToString()).ToArray());
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
