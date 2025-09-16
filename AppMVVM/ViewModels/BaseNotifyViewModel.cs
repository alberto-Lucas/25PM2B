using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppMVVM.ViewModels
{
    //Clase base para gerar as notificações
    //das propriedades(atributos) que 
    //forem alterados

    //É preciso importar a biblioteca ComponentModel
    //using System.ComponentModel;

    //Transforma a classe em abstrata
    //Classes abstratas não podem ser instanciadas
    //ou seja não é possivel, criar um objeto

    //Devemos herdar da Interface do proprio C#
    //INtofifyPropertyChanged
    public abstract class BaseNotifyViewModel : INotifyPropertyChanged
    {
        //Evento publico herdado da interface de contrato
        public event PropertyChangedEventHandler? PropertyChanged;

        //Agora iremos criar o nosso método personalizador
        //que identifica a propriedade alterada automaticamente

        //Para isso iremos utilizar o recurso
        //CallerMemberName 
        //Precisamo importar a biblioteca CompilerServices
        //using System.Runtime.CompilerServices;
        public void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            //Se a propriedade for altera irá disparar
            //o evento de Notificação
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
