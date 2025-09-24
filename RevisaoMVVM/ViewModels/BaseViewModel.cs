using System.Windows.Input;

namespace RevisaoMVVM.ViewModels
{
    public class BaseViewModel : BaseNotifyViewModel
    {
        public ICommand VoltarCommand { get; set; }

        private async void Voltar()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public async void AbrirView(ContentPage view)
        {
            await Application.Current.MainPage.Navigation.PushAsync(view);
        }

        public BaseViewModel()
        {
            VoltarCommand = new Command(Voltar);
        }
    }
}
