using LoginMVVM.Models;

namespace LoginMVVM.Services
{
    public class UsuarioService
    {
        FakeDBSingleton fakeDb = FakeDBSingleton.Instancia;
        public void Adicionar(Usuario usuario)
        {
            fakeDb.Usuario = usuario;
        }

        public Usuario GetUsuario()
        {
            return fakeDb.Usuario;
        }
    }
}
