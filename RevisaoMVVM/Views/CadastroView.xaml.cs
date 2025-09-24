using RevisaoMVVM.ViewModels;

namespace RevisaoMVVM.Views;

public partial class CadastroView : ContentPage
{
	public CadastroView()
	{
		InitializeComponent();
		BindingContext = new CarroViewModel();
	}
}