using Demographie.Maui.Models;
using Demographie.Maui.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;

namespace Demographie.Maui.ViewModels
{
    [QueryProperty("UnePersonne", "UnePersonne")]
    public partial class AddPersonnePageViewModel : ObservableObject
    {
        [ObservableProperty]
        Personne unePersonne;

        private PersonnesPageViewModel _modelViewPersonnesPointer { get; set; }
        private readonly PersonnesDatabase _personneDatabase;

        public AddPersonnePageViewModel(PersonnesDatabase personnesDatabase,
            PersonnesPageViewModel modelViewPersonnesPointer)
        {
            _modelViewPersonnesPointer = modelViewPersonnesPointer;
            _personneDatabase = personnesDatabase;
        }
        [RelayCommand]
        private async Task TakePicture()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    UnePersonne.photo = photo.FullPath;
                }
            }
        }
        [RelayCommand]
        private async Task Annuler()
        {
            await Shell.Current.GoToAsync($"//{nameof(PersonnesPage)}");
        }
            //hell.Current.GoToAsync($"//{nameof(ContactsPage)}");
            [RelayCommand]
        private async Task Sauvegarder()
        {
            if (UnePersonne.id == 0)
            {
                try
                {
                    Personne personne = new Personne(
                        prenom: UnePersonne.prenom, nom: UnePersonne.nom,  ddn: UnePersonne.ddn,
                        email: UnePersonne.email, phone: UnePersonne.phone, UnePersonne.photo);

                    await _personneDatabase.SaveItemAsync(personne);
                    _modelViewPersonnesPointer.GetData();
                    /*UnePersonne.nom = string.Empty;
                    UnePersonne.prenom = string.Empty;
                    UnePersonne.ddn = string.Empty;
                    UnePersonne.email = string.Empty;
                    UnePersonne.phone = string.Empty;*/
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                await _personneDatabase.SaveItemAsync(UnePersonne);
                _modelViewPersonnesPointer.GetData();
            }
            await Shell.Current.GoToAsync("..");
        }

    }
}