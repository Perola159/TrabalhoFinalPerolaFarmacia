using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface ICarrinhoService
    {
        // Adiciona um produto ao carrinho
        void AdicionarProdutoCarrinho(Carrinho carrinho);

        // Lista todos os produtos do carrinho
        List<CarrinhoDTO> ListarProdutoCarrinho();

        // Deleta um carrinho pelo ID
        void DeletarProdutoCarrinho(int id);

        // Edita um produto no carrinho (a ser implementado)
        void EditarProdutoCarrinho(Carrinho carrinho);
    }
}
