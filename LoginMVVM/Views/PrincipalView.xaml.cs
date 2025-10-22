using LoginMVVM.ViewModels;

namespace LoginMVVM.Views;

public partial class PrincipalView : ContentPage
{
	public PrincipalView()
	{
		InitializeComponent();
		UsuarioViewModel usuarioViewModel =
			new UsuarioViewModel();
		BindingContext = usuarioViewModel;
		usuarioViewModel.Carregar();
		//usuarioViewModel.CarregarCommand.Execute(this);
    }
}