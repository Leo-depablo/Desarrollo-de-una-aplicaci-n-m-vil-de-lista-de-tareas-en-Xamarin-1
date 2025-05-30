using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using TareasApp.Models;
using System.IO;

namespace App2.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _db;

        public DatabaseService(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Tarea>().Wait();
        }

        public Task<List<Tarea>> GetTareasAsync() => _db.Table<Tarea>().ToListAsync();

        public Task<int> SaveTareaAsync(Tarea tarea) => tarea.Id != 0
            ? _db.UpdateAsync(tarea)
            : _db.InsertAsync(tarea);

        public Task<int> DeleteTareaAsync(Tarea tarea) => _db.DeleteAsync(tarea);
    }
}
