using System.Windows.Input;

namespace AppMVVM.ViewModels
{
    //Precisamo realizar a heranaça com a classe
    //de notificação
    public class PrincipalViewModel : BaseNotifyViewModel
    {
        //Iremos definir as propriedades da tela
        //geralmente desenvolvemos primeiro a ViewModel
        //e depois o front é modelo de acordo
        //com os campos do backend

        //Propriedade simples (nao são monitoradas)
        public string Nome { get; set; }

        //Propriedade que serão monitoradas
        //Dividas em 2 partes
        //Variavel privada que ira armazenar a informaçao
        //Propriedade publica que ira manipular
        //a informação e disparar a notificação
        //OBS: o uso de underline identifica variaveis privadas
        private string _retorno;
        public string Retorno
        {
            get { return _retorno; }
            set
            {
                _retorno = value;
                //Disparar a notificação
                OnPropertyChanged();
            }
        }

        //Criar um command para a execução
        //do Botão Entrar
        //Iremos recuperar o conteudo do campo Nome
        //e atualizar a Label em tela com o conteudo
        //da propriedade Retorno
        public Command RetornoCommand
        {
            get
            {
                return new Command(() =>
                {
                    //Propriedade Retorno vai receber
                    //Uma nova string concatenada com 
                    //a propriedade Nome
                    Retorno = "Bem vindo, " + Nome;
                });
            }
        }

        //Criar um método para abrir a tela de Cliente
        private async void AbrirCliente()
        {
            await Application.Current.MainPage.
                Navigation.PushAsync(new Views.ClienteView());
        }

        //Criar o Command para execução do botão
        public ICommand AbrirClienteCommand { get; set; }

        //No contrutor da classe iremos realizar
        //o vinculo do command com o método
        public PrincipalViewModel()
        {
            //Vincular o commando
            AbrirClienteCommand = new Command(AbrirCliente);
        }
    }
}
