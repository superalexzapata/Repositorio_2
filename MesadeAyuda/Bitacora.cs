namespace MesadeAyuda
{
    public class Bitacora
    {
        private int Id;
        private int IdTicket;
        public string NombreBitacora;

        public int Id1 { get => Id; set => Id = value; }

        public void CrearBitacora(int bitacora)/*Método*/
        {
            Id = bitacora;
        }
        
        public void ConsultarBitacora()/*Método*/
        {
        }
    }
}
