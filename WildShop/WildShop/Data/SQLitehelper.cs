using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using WildShop.Models;

namespace WildShop.Data
{
    public class SQLitehelper
    {

        SQLiteAsyncConnection db;

        public SQLitehelper(string dbPath)

        {

            db = new SQLiteAsyncConnection(dbPath);

            db.CreateTableAsync<Usuarios>().Wait();
        }

          public Task <int> SaveUsuarioAsync(Usuarios Usu)

        {
            if (Usu.IdUsuario==0)
            {
                return db.InsertAsync(Usu);
            }
            else
            {
                return null;
            }
        }

    }
}
