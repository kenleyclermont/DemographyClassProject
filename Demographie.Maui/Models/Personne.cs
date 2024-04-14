using SQLite;
using CommunityToolkit.Mvvm.ComponentModel;
namespace Demographie.Maui.Models
{
    public partial class Personne : ObservableObject
    {
        public Personne()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [ObservableProperty]
        public string prenom;
        [ObservableProperty]
        public string nom;
        [ObservableProperty]
        public string ddn;
        [ObservableProperty]
        public string email;
        [ObservableProperty]
        public string phone;
        [ObservableProperty]
        public string photo;
        public string nomComplet
        {
            get { return $"{prenom} {nom}"; }
        }
        public Personne(int id, string prenom, string nom,  string ddn, string email, string phone)
        {
            this.id = id;
            this.prenom = prenom;
            this.nom = nom;
            this.ddn = ddn;
            this.email = email;
            this.phone = phone;
        }
        public Personne(string prenom, string nom, string ddn, string email, string phone, string photo)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.ddn = ddn;
            this.email = email;
            this.phone = phone;
            this.photo = photo;

        }
    }
}