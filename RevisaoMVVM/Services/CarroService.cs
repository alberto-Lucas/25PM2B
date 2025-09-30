using System;
using System.Collections.Generic;
using RevisaoMVVM.Models;

namespace RevisaoMVVM.Services
{
    //Classe para manipular o objeto Carro e gravar
    //no banco de dados
    //neste exemplo estamos gravando em uma classe Singleton
    public class CarroService
    {
        //Instanciar a classe singleton para simular
        //a conexão com o banco de dados
        //precimos importar a camada Models
        //using Nome_Projeto.Models;

        FakeDBSingleton dbSingleton = FakeDBSingleton.Instancia;

        public void Adicionar(Carro value)
        {
            dbSingleton.Carro = value;
        }
    }
}
