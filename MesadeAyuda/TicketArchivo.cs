using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesadeAyuda
{
    public class TicketArchivo
    {
        public Ticket[] Ticket;
        void GenerarTXT()
        {
            string rutaCompleta = @"Tickets.csv";
            string texto = string.Join(",", Ticket.Select(n => n.ToString()).ToArray());
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
