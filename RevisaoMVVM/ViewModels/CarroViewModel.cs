using RevisaoMVVM.Models;
using RevisaoMVVM.Views;
using RevisaoMVVM.Services;

namespace RevisaoMVVM.ViewModels
{
    //Importar as camadas Views, Models e Services;
    //using Nome_Projeto.Models;
    //using Nome_Projeto.Views;
    //using Nome_Projeto.Services;

    //Classe responsavel por gerenciar 
    //o cadastro do objeto Carro

    //Realizar a herança com a classe BaseViewModel
    public class CarroViewModel : BaseViewModel
    {
        //Instanciar a classe de serviço
        CarroService carroService = new CarroService();

        //Agora devemos criar as propriedades para acesso da tela
        //com a classe Carro gerealmente criamos um espelho
        //da classe de objeto desejado
        //esse formato de propriedade se chama encapsulamento

        //Cria a variavel privada para armazenar os dados
        private string _marca;
        //Criar a propriedade de manipulação
        public string Marca
        {
            get { return _marca; } //Retornar dado gravado
            set
            {
                _marca = value; //gravar os dados
                OnPropertyChanged(); //disparar a notificação
            }
        }

        private string _modelo;

        public string Modelo
        {
            get { return _modelo; } //Retornar dado gravado
            set
            {
                _modelo = value; //gravar os dados
                OnPropertyChanged(); //disparar a notificação
            }
        }

        private string _cor;

        public string Cor
        {
            get { return _cor; } //Retornar dado gravado
            set
            {
                _cor = value; //gravar os dados
                OnPropertyChanged(); //disparar a notificação
            }
        }
    }
}
