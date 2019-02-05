using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace TaskKitLTA.BD
{
    public class TaskRepository
    {
        private SQLiteConnection con;

        private static TaskRepository instancia;
        public static TaskRepository Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new TaskRepository(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "pendientes.db3"));
                    // throw new Exception("Error llama inicializador");
                }
                return instancia;
            }
        }

        public static void Inicializador(String Filename)
        {

            if (Filename == null)
                throw new ArgumentNullException();  

            if (Instancia != null)
                instancia.con.Close();


            instancia = new TaskRepository(Filename);
        }

        private TaskRepository(String dbPath)
        {
            con = new SQLiteConnection(dbPath);

            con.CreateTable<PendientesBD>();
        }


        public void EliminarPicking(PendientesBD listaP)
        {
            con.Delete(listaP);
        }

        public IEnumerable<PendientesBD> GetAllPendientes()
        {
            try
            {
                return con.Table<PendientesBD>();
            }
            catch (Exception exMess)
            {
                Mensaje = exMess.Message;
            }

            return Enumerable.Empty<PendientesBD>();
        }


        public int AddPendientes(string Titulo, string desc, DateTime fecha)
        {

            int result = 0;

            try
            {
                PendientesBD pendientes;
                result = con.Insert(pendientes = new PendientesBD()
                {
                    Titulo = Titulo,
                    Descripcion = desc,
                    Fecha = fecha
                });
                Mensaje = string.Format("Cantidad de nuevas filas afectadas: {0}", result);
            } catch (Exception exMss)
            {
                Mensaje = exMss.Message;
            }

            return result;
        }

        public int octenerID()
        {
           // var id = con.Query<Stock>("Select Id From pendiente where Titulo = ",);
            return 0;
        }

        public List<PendientesBD> GetPendiente()
        {
            var stock = con.Query<PendientesBD>("select * from pendientes");
            return stock;
        }

        public string Mensaje;
    }
}
