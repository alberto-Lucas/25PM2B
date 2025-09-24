using System.Windows.Input;
using RevisaoMVVM.Models;
using RevisaoMVVM.Services;
using RevisaoMVVM.Views;

namespace RevisaoMVVM.ViewModels
{
    public class CarroViewModel : BaseViewModel
    {
        CarroService carroService = new CarroService();

        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set
            {
                _marca = value;
                OnPropertyChanged();
            }
        }

        private string _modelo;

        public string Modelo
        {
            get { return _modelo; }
            set
            {
                _modelo = value;
                OnPropertyChanged();
            }
        }

        private string _cor;

        public string Cor
        {
            get { return _cor; }
            set
            {
                _cor = value;
                OnPropertyChanged();
            }
        }

        public ICommand CadastrarCommand { get; set; }
        
        void Cadastrar()
        {
            Carro carro = new Carro();
            carro.Marca = Marca;
            carro.Modelo = Modelo;
            carro.Cor = Cor;

            carroService.Adicionar(carro);

            AbrirView(new VisualizarView());
        }

        public ICommand CarregarCommand { get; set; }
        void Carregar()
        {
            Carro carro = new Carro();
            carro = carroService.Consultar();

            Marca = carro.Marca;
            Modelo = carro.Modelo;
            Cor = carro.Cor;
        }

        public CarroViewModel()
        {
            CadastrarCommand = new Command(Cadastrar);
            CarregarCommand = new Command(Carregar);
        }
    }
}
