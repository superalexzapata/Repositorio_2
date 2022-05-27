namespace MesadeAyuda
{
    public class Tecnico : Persona /*Herencia*/
    {
        public string NombreTecnico;
        public GrupoSoporte GrupoSoporte;
        internal string Password;

        public Tecnico(GrupoSoporte gpoSop1) /*Constructor*/
        {
            this.GrupoSoporte = gpoSop1; /*Composición*/
        }

        public Tecnico()
        {
        }

        public void CrearTecnico()/*Método*/
        {
        }

        public void ConsultarTecnico()/*Método*/
        {
        }

        public void ActualizarTecnico()/*Método*/
        {
        }
    }
}
