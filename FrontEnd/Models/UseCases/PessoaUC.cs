using System.Net.Http.Json;
using TrabalhoFinal._03_Entidades.DTOS;

namespace FrontEnd.Models.UseCases
{
    public class PessoaUC
    {
        private readonly HttpClient _client;
        public PessoaUC(HttpClient cliente)
        {
            _client = cliente;
        }

        //public async Task<List<Pessoa>> ListarUsuariosAsync()
        //{
        //    return await _client.GetFromJsonAsync<List<Pessoa>>("Pessoa/listar-Pessoa");
        //}
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
            HttpResponseMessage response = _client.PostAsJsonAsync("Pessoa/fazer-login", usuLogin).Result;
            Pessoa usuario = response.Content.ReadFromJsonAsync<Pessoa>().Result;
            return usuario;
        }
    }
}
