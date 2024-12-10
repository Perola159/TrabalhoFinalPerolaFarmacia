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

        public void EditarProdutoCarrinho(int id)
        {
            var carrinho = _carrinhos.FirstOrDefault(c => c.Id == id);
            if (carrinho != null)
            {
                // Lógica de edição aqui
            }
        }

        public List<CarrinhoDTO> ListarCarrinhosComDetalhes()
        {
            return _carrinhos.Select(c => new CarrinhoDTO
            {
                Id = c.Id,
                Itens = c.Itens.Select(i => new Item
                {
                    ProdutoId = i.ProdutoId,
                    Quantidade = i.Quantidade,
                    Preco = i.Preco
                }).ToList()
            }).ToList();
        }
    }
}

