using Demographie.Maui.Models;
using Demographie.Maui.Services;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Demographie.Maui.Views;

namespace Demographie.Maui.ViewModels
{
    public partial class PersonnesPageViewModel : ObservableObject
    {
        private readonly PersonneService _personneService;
        [ObservableProperty]
        public ObservableCollection<Personne> modelViewPersonnes = new();
        public PersonnesPageViewModel(PersonneService personneService)
        {
            _personneService = personneService;
            GetData();
        }
        public async void GetData()
        {
            List<Personne> temp = await _personneService.LoadPersonnes();
            if (modelViewPersonnes.Count > 0)
            {
                modelViewPersonnes.Clear();
            }
            foreach (Personne item in temp)
            {
                modelViewPersonnes.Add(item);
            }
            OnPropertyChanged(nameof(modelViewPersonnes));
        }
        [RelayCommand]
        private async Task EntrerNouvellePersonne()
        {
            Personne personne = new Personne();
            var parameters = new Dictionary<string, object>
            {
                {"UnePersonne", personne}

            };
            await Shell.Current.GoToAsync(nameof(AddPersonnePage), true, parameters);
        }

        [RelayCommand]
        private async Task EditPersonne(Personne personne)
        {
            var parameters = new Dictionary<string, object>
            {
                {"UnePersonne", personne}

            };
            await Shell.Current.GoToAsync(nameof(AddPersonnePage), true, parameters);
        }
    }
}