/*
 * Auteur: Kenley Clermont
 * Date: 10/04/2024
 * Objectif: Ecrire une application Mobile avec .Net Maui pour accepter des donn�es d�mographiques.
 *           Utiliser la technologie MVVM au moins pour la liste.
 *           L'�cran principal pr�sente une liste de noms. Chaque �l�ment de la liste contient 2 lignes,  
 *           pr�nom et nom sur une ligne, email sur la 2e ligne et photo � gauche des 2 lignes dans une 
 *           colonne. Au bas de la page est un bouton (Nouveau Nom) pour ajouter d'autres donn�es.
 *           Quand le bouton est press� le 2e �cran acceptera : Pr�nom, Nom, Date de Naissance, 
 *           Email, Phone, Photo (Utilisez Cam�ra de l'appareil). 2 boutons (Ajouter et Annuler) au bas 
 *           de l'�cran pour annuler ou ajouter la nouvelle personne � la liste.
 *
 *           Les informations seront persist�es dans une base de donn�es Sqlite.
 */
using Demographie.Maui.ViewModels;
namespace Demographie.Maui.Views;

public partial class PersonnesPage : ContentPage
{
	public PersonnesPage(PersonnesPageViewModel PersonnesPageViewModel)
	{
		InitializeComponent();
		BindingContext = PersonnesPageViewModel;
	}
}