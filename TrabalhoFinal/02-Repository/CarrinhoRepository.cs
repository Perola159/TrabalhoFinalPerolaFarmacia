using System.Runtime.Intrinsics.X86;
using System;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._02_Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private readonly List<Carrinho> _carrinhos = new List<Carrinho>();

        public void AdicionarProdutoCarrinho(Carrinho carrinho)
        {
            _carrinhos.Add(carrinho);
        }

        public void AdicionarItem(Carrinho carrinho, Item item)
        {
            var carrinhoExistente = _carrinhos.FirstOrDefault(c => c.Id == carrinho.Id);
            if (carrinhoExistente != null)
            {
                carrinhoExistente.Itens.Add(item);
            }
        }

        public Carrinho BuscarCarrinhoPorId(int id)
        {
            return _carrinhos.FirstOrDefault(c => c.Id == id);
        }

        public void EditarProdutoCarrinho(Carrinho carrinhoEditado)
        {
            var carrinho = _carrinhos.FirstOrDefault(c => c.Id == carrinhoEditado.Id);
            if (carrinho != null)
            {
                carrinho.IdPessoa = carrinhoEditado.IdPessoa;
                carrinho.IdProduto = carrinhoEditado.IdProduto;
                // Atualize outros campos necessários
            }
        }

        public List<CarrinhoDTO> ListarCarrinhosComDetalhes()
        {
            // Lista sem incluir "Itens"
            return _carrinhos.Select(c => new CarrinhoDTO
            {
                //A interrogação?.é tipo uma forma de "perguntar" se
                //o objeto existe antes de tentar acessar algo dentro dele.
                Id = c.Id,
                IdPessoa = c.IdPessoa,   
                NomePessoa = c.Pessoa?.Nome ?? "Nome não informado",
                IdProduto = c.IdProduto,
                NomeProduto = c.Produto?.Nome ?? "Produto não informado",
                PrecoProduto = c.Produto?.Preco ?? 0
            }).ToList();
        }

        public void DeletarCarrinho(int id)
        {
            var carrinho = _carrinhos.FirstOrDefault(c => c.Id == id);
            if (carrinho != null)
            {
                _carrinhos.Remove(carrinho);
            }
        }
    }
}
