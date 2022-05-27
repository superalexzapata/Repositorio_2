﻿namespace MesadeAyuda
{
    public class Ticket
    {
        private int Id;
        public string TituloFalla;
        private string DescripcionProblema;
        private string Problema;
        public Categoria Categoria;
        public TipoSolicitud TipoSolicitud;
        public Estadistica Estadistica;
        public Prioridad Prioridad;
        public Bitacora Bitacora;
        public Usuario Usuario;
        public Tecnico Tecnico;
        public GrupoSoporte GrupoSoporte;

        

        public Ticket(GrupoSoporte gpoSop3) /*Constructor*/
        {
            this.GrupoSoporte = gpoSop3; /*Composición*/
        }

        public Ticket(TipoSolicitud tipoSol) /*Constructor*/
        {
            this.TipoSolicitud = tipoSol; /*Composición*/
        }

        public Ticket(Categoria tipoCateg) /*Constructor*/
        {
            this.Categoria = tipoCateg; /*Composición*/
        }

        public Ticket(Estadistica nomEst) /*Constructor*/
        {
            this.Estadistica = nomEst; /*Composición*/
        }

        public Ticket(Prioridad nomPrio) /*Constructor*/
        {
            this.Prioridad = nomPrio; /*Composición*/
        }

        public Ticket(Bitacora nomBit) /*Constructor*/
        {
            this.Bitacora = nomBit; /*Composición*/
        }

        public Ticket(Usuario nomUsu) /*Constructor*/
        {
            this.Usuario = nomUsu; /*Composición*/
        }

        public Ticket(Tecnico nomTec) /*Constructor*/
        {
            this.Tecnico = nomTec; /*Composición*/
        }

        public Ticket()
        {
        }

        public void CrearTicket(int ticket, string tituloFalla, string descripcion) 
        {
            Id = ticket;
            TituloFalla = tituloFalla;
            DescripcionProblema = descripcion;
        }

    }

}
