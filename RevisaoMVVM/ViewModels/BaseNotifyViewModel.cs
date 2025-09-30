

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RevisaoMVVM.ViewModels
{
    //Classe de notificações

    //Deixaremos a classe do abstratic pois a mesma
    //não será instanciada
    //E realizaremos a herança com a
    //Interface(Contrato)  INotifyPropertyChanged
    //
    public abstract class BaseNotifyViewModel : INotifyPropertyChanged
    {
        //Evento de assinatura criado automaticamente
        //ao realizar a herança
        public event PropertyChangedEventHandler? PropertyChanged;

        //Implementar o método para identificação automatica
        //da propriedade q sofreu alterção
        //Importar as blibliotecas abaixo
        //using System.ComponentModel;
        //using System.Runtime.CompilerServices;

        public void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            //Iremos invocar a nossa notificação
            PropertyChanged?.Invoke
                (this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
