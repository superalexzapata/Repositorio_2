namespace MesadeAyuda // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a la Mesa de Ayuda");

         #region Usuarios
            #region Primer Usuario
            Ubicacion ubi1 = new Ubicacion();
            ubi1.NombreUbicacion = "Sede Manizales";
            Usuario usuario1 = new Usuario(ubi1);
            usuario1.TipoIdentificacion = "CC";
            usuario1.NumeroIdentificacion = 123456;
            usuario1.Nombre = "Pedro Perez";
            usuario1.Direccion = "Calle 32";
            usuario1.Edad = 20;
            usuario1.EsActivo = true;
            usuario1.Telefono = 318000;
            usuario1.Password = "Abcd123";//Asignación de contraseña
            usuario1.Sexo = "M";
            usuario1.RegistrarPersona(1);//Asignacion de ID
            usuario1.Email = "pperez@gmail.com";
            #endregion

            #region Segundo Usuario
            Ubicacion ubi2 = new Ubicacion();
            ubi2.NombreUbicacion = "Sede Pasto";
            Usuario usuario2 = new Usuario(ubi2);
            usuario2.TipoIdentificacion = "CC";
            usuario2.NumeroIdentificacion = 789465;
            usuario2.Nombre = "Mauricio Florez";
            usuario2.Direccion = "Carrera 21";
            usuario2.Edad = 30;
            usuario2.EsActivo = true;
            usuario2.Telefono = 128000;
            usuario2.Password = "Wxyz654";//Asignación de contraseña
            usuario2.Sexo = "M";
            usuario2.RegistrarPersona(2);//Asignación de ID
            usuario2.Email = "mflorez@gmail.com";
            #endregion

            #region Tercer Usuario 
            Ubicacion ubi3 = new Ubicacion();
            ubi3.NombreUbicacion = "Ubicación Cartagena";
            Persona unaPersona = new Persona();
            unaPersona.TipoIdentificacion = "CC";
            unaPersona.NumeroIdentificacion = 020301;
            unaPersona.Nombre = "Martha Ocampo";
            unaPersona.Direccion = "Avenida 15";
            unaPersona.Edad = 40;
            unaPersona.EsActivo = true;
            unaPersona.Telefono = 519000;
            unaPersona.Password = "Lkjh369";//Asignación de contraseña
            unaPersona.RegistrarPersona(3);//Asignación de ID
            unaPersona.Sexo = "F";
            unaPersona.Email = "mocampo@gmail.com";
            #endregion


            List<Usuario> milistaUsuarios = new List<Usuario>();
            milistaUsuarios.Add(usuario1);
            milistaUsuarios.Add(usuario2);
            //milistaUsuarios.Add(unaPersona);

            UsuarioArchivo creadorUsuarios = new UsuarioArchivo();
            creadorUsuarios.listaUsuarios = milistaUsuarios;
            creadorUsuarios.GenerarTxtUsuarios();
            Console.WriteLine("Listo el archivo Usuarios.csv\nGracias!!!");
         #endregion

         #region Tecnicos
            #region Tecnico 1
            GrupoSoporte gpoSop1 = new GrupoSoporte();
            gpoSop1.GrupoSop = "Hardware";
            Tecnico tecnico1 = new Tecnico(gpoSop1);
            tecnico1.TipoIdentificacion = "CC";
            tecnico1.NumeroIdentificacion = 963258;
            tecnico1.Nombre = "Camilo Solarte";
            tecnico1.Direccion = "Calle 23";
            tecnico1.Edad = 25;
            tecnico1.EsActivo = true;
            tecnico1.Telefono = 8897755;
            tecnico1.Password = "C4milo12";//Asignación de contraseña
            tecnico1.RegistrarPersona(1);//Asignación de ID
            tecnico1.Sexo = "M";
            tecnico1.Email = "csolarte@gmail.com";
            #endregion

            #region Segundo Tecnico con polimorfismo
            GrupoSoporte gpoSop2 = new GrupoSoporte();
            gpoSop2.GrupoSop = "Redes";
            Persona unTecnico = new Persona();
            unaPersona.TipoIdentificacion = "CC";
            unTecnico.NumeroIdentificacion = 020301;
            unTecnico.Nombre = "Patricia Lopez";
            unTecnico.Direccion = "Avenida 232";
            unTecnico.Edad = 18;
            unTecnico.EsActivo = false;
            unTecnico.Telefono = 8849696;
            unTecnico.Password = "P4tr1c14";//Asignación de contraseña
            unTecnico.RegistrarPersona(2);//Asignación de ID
            unTecnico.Sexo = "F";
            unTecnico.Email = "plopez@gmail.com";
            #endregion

            #region Lista Tecnicos
            List<Tecnico> milistaTecnicos = new List<Tecnico>();
            milistaTecnicos.Add(tecnico1);
            //milistaTecnicos.Add((Tecnico)unTecnico);
            #endregion

            TecnicoArchivo creadorTecnicos = new TecnicoArchivo();
            creadorTecnicos.listaTecnicos = milistaTecnicos;
            creadorTecnicos.GenerarTxtTecnicos();
            Console.WriteLine("Listo el archivo Tecnicos.csv\nGracias!!!");
         #endregion

         #region Tickets
            #region Ticket
            GrupoSoporte gpoSop3 = new GrupoSoporte();
            gpoSop3.GrupoSop = "Software";
            Ticket ticket1 = new Ticket(gpoSop3);
            //ticket1.CrearTicket(1, "Daño en Office", "No me abre Word");//Asignación de id, Titulo falla y Descripcion
            ticket1.TituloFalla = "Daño en Office";

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