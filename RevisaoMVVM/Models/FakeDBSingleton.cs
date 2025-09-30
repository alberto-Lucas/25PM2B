namespace RevisaoMVVM.Models
{
    //Classe Singleton para Simular um banco de dados
    //onde o objeto Carro será salvo temporariamente
    public sealed class FakeDBSingleton
    {
        //o uso de underline serve como boa pratica
        //para identificação de variaveis privadas
        static FakeDBSingleton _instancia;

        public static FakeDBSingleton Instancia
        { 
            get
            {
                return _instancia ??
                    (_instancia = new FakeDBSingleton());
            }
        }

        //Criar uma atributo do tipo Carro para salvar o cadastro
        //Simulando uma tabela de banco de dados
        public Carro Carro { get; set; }
    }
}
