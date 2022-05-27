using System.Collections;
using System.Text;

namespace MesadeAyuda
{
    public class TicketArchivo
    {
        public List<Ticket> listaTickets;
        public void GenerarTxtTickets()
        {
            string rutaCompleta = @"3-Tickets.csv";

            var unaCadenadeTickets = new StringBuilder();

            // Build the users string.
            foreach (Ticket unTicket in listaTickets)
            {
                unaCadenadeTickets.Append(unTicket.Id4 + ") ");
                unaCadenadeTickets.Append(unTicket.TituloFalla);
                unaCadenadeTickets.Append("; ");
                unaCadenadeTickets.Append(unTicket.DescripcionProblema);
                unaCadenadeTickets.Append("; ");
                /*unaCadenadeTickets.Append(unTicket.Categoria.NombreCategoria);
                unaCadenadeTickets.Append(";");
                unaCadenadeTickets.Append(unTicket.TipoSolicitud.NombreSolicitud);
                unaCadenadeTickets.Append(";");
                unaCadenadeTickets.Append(unTicket.Estadistica.NombreEstadistica);
                unaCadenadeTickets.Append(";");
                unaCadenadeTickets.Append(unTicket.Prioridad.NombrePrioridad);
                unaCadenadeTickets.Append(";");
                unaCadenadeTickets.Append(unTicket.Bitacora.NombreBitacora);
                unaCadenadeTickets.Append(";");
                unaCadenadeTickets.Append(unTicket.Usuario.Nombre);
                unaCadenadeTickets.Append(";");
                unaCadenadeTickets.Append(unTicket.Tecnico.Nombre);
                unaCadenadeTickets.Append(";");
                unaCadenadeTickets.Append(unTicket.GrupoSoporte.GrupoSop);*/
                unaCadenadeTickets.Append("\n");

            }

            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                mylogs.WriteLine(unaCadenadeTickets.ToString());
                mylogs.Close();
            }
        }
    }

}
