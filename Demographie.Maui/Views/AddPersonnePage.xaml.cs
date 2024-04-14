using Demographie.Maui.ViewModels;

namespace Demographie.Maui.Views;

public partial class AddPersonnePage : ContentPage
{
	public AddPersonnePage(AddPersonnePageViewModel personnePageViewModel)
	{
		InitializeComponent();
		BindingContext = personnePageViewModel;
	}
}