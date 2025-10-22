using System.Windows.Input;

namespace LoginMVVM.ViewModels
{
    public class BaseViewModel : BaseNotifyViewModel
    {
        //Command para acessar direto da View
        public ICommand VoltarCommand { get; set; }
        //Método comum para acessar direto do Backend
        public async void Voltar()
        {
            await Application.Current.MainPage.
                Navigation.PopAsync();
        }
        //Método comum para acessar direto do Backend
        public async void AbrirView(ContentPage view)
        {
            await Application.Current.MainPage.
                Navigation.PushAsync(view);
        }

        public async void MsgInfo(string conteudo)
        {
            await Application.Current.MainPage.
                DisplayAlert("Informação...",
                             conteudo,
                             "OK");
        }

        //Quando utilizar async e esperar um tipo de dado
        //como retorno, é preciso utilizar o Task
        //Task<tipo_dado> ex: Task<int>....
        public async Task<bool> MsgSimNao(string conteudo)
        {
            //A primeira sempre será a sim
            //ou seja cliacado na primeira opção
            //irá retornar true
            //clicado na segunda retorna false
            return 
                await Application.Current.MainPage.
                    DisplayAlert("Confirmação...",
                                 conteudo,
                                 "Sim", "Não");
        }

        public BaseViewModel()
        {
            VoltarCommand = new Command(Voltar);
        }
    }
}
