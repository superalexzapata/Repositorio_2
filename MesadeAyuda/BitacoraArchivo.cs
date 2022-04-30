﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesadeAyuda
{
    internal class BitacoraArchivo
    {
        public Bitacora[] Bitacora;
        void GenerarTXT()
        {
            string rutaCompleta = @"Bitacoras.csv";
            string texto = string.Join(",", Bitacora.Select(n => n.ToString()).ToArray());
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
