using RevisaoMVVM.ViewModels;

namespace RevisaoMVVM.Views;

public partial class CarroCadastroView : ContentPage
{
	public CarroCadastroView()
	{
		InitializeComponent();
        //Importar a camada de ViewModel
        //using Nome_Projeto.ViewModels;

        //Vincular o front com o back-end
        BindingContext = new CarroViewModel();
    }
}