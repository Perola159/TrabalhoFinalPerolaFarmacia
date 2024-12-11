using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._02_Repository.Interfaces
{
    public interface ICarrinhoRepository
    {
        // Adiciona um produto ao carrinho
        void AdicionarProdutoCarrinho(Carrinho carrinho);

        // Edita um produto no carrinho
        void EditarProdutoCarrinho(Carrinho carrinho);

        // Lista os carrinhos com detalhes (Pessoa e Produto)
        List<CarrinhoDTO> ListarCarrinhosComDetalhes();

        // Deleta um carrinho pelo seu ID
        void DeletarCarrinho(int id);
    }
}
