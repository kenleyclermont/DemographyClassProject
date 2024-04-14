using Demographie.Maui.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Demographie.Maui.Services
{
    public class PersonneService : ObservableObject
    {
        PersonnesDatabase _personnesDatabase;
        public PersonneService(PersonnesDatabase personnesDatabase)
        {
            _personnesDatabase = personnesDatabase;
        }
        public async Task<List<Personne>> LoadPersonnes()
        {
            return await _personnesDatabase.GetItemsAsync();
        }
    }
}