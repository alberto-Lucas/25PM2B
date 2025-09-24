using RevisaoMVVM.ViewModels;

namespace RevisaoMVVM.Views;

public partial class VisualizarView : ContentPage
{
	public VisualizarView()
	{
		InitializeComponent();
        var carroViewModel = new CarroViewModel();
		BindingContext = carroViewModel;
        carroViewModel.CarregarCommand.Execute(null);
	}
}