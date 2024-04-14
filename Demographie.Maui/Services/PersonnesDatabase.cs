using Demographie.Maui.Models;
using SQLite;
using System.Diagnostics;

namespace Demographie.Maui.Services
{
    public class PersonnesDatabase
    {
        SQLiteAsyncConnection Database;
        public PersonnesDatabase()
        {

        }
        // Create the database if it does not exist.
        async Task Init()
        {
            if (Database is not null)
                return;
            try
            {
                Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
                var result = await Database.CreateTableAsync<Personne>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        // Return a list of all the rows of the class Personne.
        public async Task<List<Personne>> GetItemsAsync()
        {
            await Init();
            return await Database.Table<Personne>().ToListAsync();
        }
        // Return a variable of type Personne with information corresponding to id.
        public async Task<Personne> GetItemAsync(int id)
        {
            await Init();
            return await Database.Table<Personne>().Where(i => i.id == id).FirstOrDefaultAsync();
        }
        // Create or Update if information already exists.
        public async Task<int> SaveItemAsync(Personne item)
        {
            await Init();
            if (item.id != 0)
            {
                return await Database.UpdateAsync(item);
            }
            else
            {
                return await Database.InsertAsync(item);
            }
        }
        // Delete record item
        public async Task<int> DeleteItemAsync(Personne item)
        {
            await Init();
            return await Database.DeleteAsync(item);
        }

    }
}
