using AppMVVM.ViewModels;

namespace AppMVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
		//Primeiro precisamos importar a camada
		//ViewModel
		//using AppMVVM.ViewModels;

		//Iremos realizar o vinculo da tela
		//com a viewModel
		this.BindingContext = new PrincipalViewModel();
	}
}