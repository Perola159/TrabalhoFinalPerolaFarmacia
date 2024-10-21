using System.Net.Http.Json;

namespace FrontEnd.Models.UseCases
{
    public class PessoaUC
    {
        private readonly HttpClient _client;
        public PessoaUC(HttpClient cliente)
        {
            _client = cliente;
        }
        public List<Pessoa> ListarUsuarios()
        {
            return _client.GetFromJsonAsync<List<Pessoa>>("Pessoa/listar-Pessoa").Result;
        }
        public void CadastrarUsuario(Pessoa usuario)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Pessoa/adicionar-pessoa", usuario).Result;
        }
        public Pessoa FazerLogin(UsuarioLoginDTO usuLogin)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Usuario/fazer-login", usuLogin).Result;
            Pessoa usuario = response.Content.ReadFromJsonAsync<Pessoa>().Result;
            return usuario;
        }
    }
}
