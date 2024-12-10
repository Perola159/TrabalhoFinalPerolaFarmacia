using System.Net.Http.Json;
using FrontEnd.Models;
using TrabalhoFinal._03_Entidades;

namespace FrontEnd.Models.UseCases
{
    public class CarrinhoUC
    {
        private readonly HttpClient _client;
        public CarrinhoUC(HttpClient cliente)
        {
            _client = cliente;
        }
        public void CadastrarCarrinho(Carrinho carrinho)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Carrinho/adicionar-carrinho", carrinho).Result;
        }
        public List<ReadCarrinhoDTO> ListarCarrinhoUsuarioLogado(int usuarioId)
        {
            return _client.GetFromJsonAsync<List<ReadCarrinhoDTO>>("Carrinho/listar-carrinho-do-usuario?usuarioId=" + usuarioId).Result;
        }
    }
}
