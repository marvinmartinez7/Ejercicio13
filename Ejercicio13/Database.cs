using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;


namespace Ejercicio13
{
    public class Database
    {

        readonly SQLiteAsyncConnection db;

        //Constructor
        public Database(String pathdb)
        {
            //Crear conexion a la BD
            db = new SQLiteAsyncConnection(pathdb);

            //Crear tabla Personas en SQLite
            db.CreateTableAsync<Personas>().Wait();
        }

        //READ
        public Task<List<Personas>> ListaPersonas()
        {
            return db.Table<Personas>().ToListAsync();

        }

        //INSERT & UPDATE
        public Task<int> GrabarPersonas(Personas datos)
        {
            if (datos.id != 0)
            {
                return db.UpdateAsync(datos);
            }
            else
            {

                return db.InsertAsync(datos);
            }
        }

        //DELETE
        public Task<int> EliminarPersonas(Personas datos)
        {
            return db.DeleteAsync(datos);
        }
    }
}
