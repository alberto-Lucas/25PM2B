using LoginMVVM.ViewModels;

namespace LoginMVVM.Views;

public partial class CadastroView : ContentPage
{
	public CadastroView()
	{
		InitializeComponent();
		BindingContext = new UsuarioViewModel();
	}
}