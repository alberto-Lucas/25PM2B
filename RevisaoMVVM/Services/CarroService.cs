using RevisaoMVVM.Models;

namespace RevisaoMVVM.Services
{
    public class CarroService
    {
        FakeDBSingleton dbSingleton = FakeDBSingleton.Instancia;

        public void Adicionar(Carro carro)
        {
            dbSingleton.Carro = carro;
        }

        public Carro Consultar() 
        { 
            return dbSingleton.Carro;
        }
    }
}
