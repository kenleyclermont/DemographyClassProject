/*
 * Auteur: Kenley Clermont
 * Date: 10/04/2024
 * Objectif: Ecrire une application Mobile avec .Net Maui pour accepter des données démographiques.
 *           Utiliser la technologie MVVM au moins pour la liste.
 *           L'écran principal présente une liste de noms. Chaque élément de la liste contient 2 lignes,  
 *           prénom et nom sur une ligne, email sur la 2e ligne et photo à gauche des 2 lignes dans une 
 *           colonne. Au bas de la page est un bouton (Nouveau Nom) pour ajouter d'autres données.
 *           Quand le bouton est pressé le 2e écran acceptera : Prénom, Nom, Date de Naissance, 
 *           Email, Phone, Photo (Utilisez Caméra de l'appareil). 2 boutons (Ajouter et Annuler) au bas 
 *           de l'écran pour annuler ou ajouter la nouvelle personne à la liste.
 *
 *           Les informations seront persistées dans une base de données Sqlite.
 */
namespace Demographie.Maui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

    }

}
