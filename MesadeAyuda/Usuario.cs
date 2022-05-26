namespace MesadeAyuda
{

    /// <summary>
    /// Clase que administra los usuarios del sistema
    /// </summary>
    public class Usuario : Persona /*Herencia*/
    {
        public string Password;
        public bool EsActivo;        
        public Ubicacion UbicacionUsuario;

        public Usuario(Ubicacion ubicacion) /*Composición*/
        {
            this.UbicacionUsuario = ubicacion;
        }

        public Usuario()
        {
        }

        public void CrearUsuario()/*Método*/
        {
        }

        public void ConsultarUsuario()/*Método*/
        {
        }

        public void ActualizarUsuario()/*Método*/
        {
        }

    }
}
