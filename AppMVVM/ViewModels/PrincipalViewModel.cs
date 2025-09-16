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

    }
}
