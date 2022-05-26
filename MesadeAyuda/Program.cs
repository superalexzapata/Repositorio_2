namespace MesadeAyuda // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la Mesa de Ayuda");

         #region Usuarios
            #region PrimerUsuario
            Ubicacion ubi1 = new Ubicacion();
            ubi1.NombreUbicacion = "Sede Manizales";
            Usuario usuario1 = new Usuario(ubi1);
            //Persona.TipoIdentificacion tipoDoc = Persona.TipoIdentificacion.cc;
            usuario1.NumeroIdentificacion = 123456;
            usuario1.Nombre = "Pedro Perez";
            usuario1.Direccion = "Calle 32";
            usuario1.Edad = 20;
            usuario1.EsActivo = true;
            usuario1.Telefono = 318000;
            usuario1.Password = "Abcd123";//Asignación de contraseña
            usuario1.RegistrarPersona("M",1);//Asignación de sexo y ID
            usuario1.Email = "pperez@gmail.com";
            #endregion

            #region Segundo Usuario
            Ubicacion ubi2 = new Ubicacion();
            ubi2.NombreUbicacion = "Sede Pasto";
            Usuario usuario2 = new Usuario(ubi2);
            //usuario2.TipoIdentificacion = Usuario.TipoIdentificacion.cc;
            usuario2.NumeroIdentificacion = 789465;
            usuario2.Nombre = "Mauricio Florez";
            usuario2.Direccion = "Carrera 21";
            usuario2.Edad = 30;
            usuario2.EsActivo = true;
            usuario2.Telefono = 128000;
            usuario2.Password = "Wxyz654";//Asignación de contraseña
            usuario2.RegistrarPersona("M",2);//Asignación de sexo
            usuario2.Email = "mflorez@gmail.com";
            #endregion

            #region Tercer Usuario con polimorfismo
            Ubicacion ubi3 = new Ubicacion();
            ubi3.NombreUbicacion = "Ubicación Cartagena";
            Persona unaPersona = new Persona();
            //unaPersona.TipoIdentificacion = Usuario.TipoIdentificacion.cc;
            unaPersona.NumeroIdentificacion = 020301;
            unaPersona.Nombre = "Martha Ocampo";
            unaPersona.Direccion = "Avenida 15";
            unaPersona.Edad = 40;
            unaPersona.EsActivo = true;
            unaPersona.Telefono = 519000;
            unaPersona.Password = "Lkjh369";//Asignación de contraseña
            unaPersona.RegistrarPersona("F",3);//Asignación de sexo
            unaPersona.Email = "mocampo@gmail.com";
            #endregion


            List<Usuario> milistaUsuarios = new List<Usuario>();
            milistaUsuarios.Add(usuario1);
            milistaUsuarios.Add(usuario2);
            //milistaUsuarios.Add((Usuario)unaPersona);

            UsuarioArchivo creadorUsuarios = new UsuarioArchivo();
            creadorUsuarios.listaUsuarios = milistaUsuarios;
            creadorUsuarios.GenerarTxtUsuarios();
            Console.WriteLine("Listo el archivo Usuarios.csv\nGracias!!!");
            #endregion

         #region Tecnicos
            
            pegue aquí el Código técnicos

         #endregion

         #region Tickets
            #region Ticket
            GrupoSoporte gpoSop3 = new GrupoSoporte();
            gpoSop3.GrupoSop = "Software";
            Ticket ticket1 = new Ticket(gpoSop3);
            ticket1.CrearTicket(1, "Daño en Office", "No me abre Word");//Asignación de id, Titulo falla y Descripcion

            Categoria tipoCateg = new Categoria();
            tipoCateg.NombreCategoria= "Software" ;
            Ticket ticket2 = new Ticket(tipoCateg);

            TipoSolicitud tipoSol = new TipoSolicitud();
            tipoSol.NombreSolicitud = "Suite Office";
            Ticket ticket3 = new Ticket(tipoSol);

            Estadistica nomEst = new Estadistica();
            nomEst.NombreEstadistica= "Reporte Daños por Software";
            Ticket ticket4 = new Ticket(nomEst);

            Prioridad nomPrio = new Prioridad();
            nomPrio.NombrePrioridad= "Tipo 2";
            Ticket ticket5 = new Ticket(nomPrio);

            Bitacora nomBit = new Bitacora();
            nomBit.NombreBitacora= "Se reinstaló suite de Office";
            Ticket ticket6 = new Ticket(nomBit);

            Usuario nomUsu = new Usuario();
            nomUsu.Nombre = "Pedro Perez";
            Ticket ticket7 = new Ticket(nomUsu);

            Tecnico nomTec = new Tecnico();
            nomTec.Nombre = "Camilo Solarte";
            Ticket ticket8 = new Ticket(nomTec);
            #endregion

            
            #region Lista Tickets
            List<Ticket> milistaTickets = new List<Ticket>();
            milistaTickets.Add(ticket1);
            milistaTickets.Add(ticket2);
            milistaTickets.Add(ticket3);
            milistaTickets.Add(ticket4);
            milistaTickets.Add(ticket5);
            milistaTickets.Add(ticket6);
            milistaTickets.Add(ticket7);
            milistaTickets.Add(ticket8);
            //milistaTickets.Add((Ticket)unTicket);
            #endregion

            TicketArchivo creadorTickets = new TicketArchivo();
            creadorTickets.listaTickets = milistaTickets;
            creadorTickets.GenerarTxtTickets();
            Console.WriteLine("Listo el archivo Tickets.csv\nGracias!!!");
            Console.Read();
         #endregion

        }


    }
}