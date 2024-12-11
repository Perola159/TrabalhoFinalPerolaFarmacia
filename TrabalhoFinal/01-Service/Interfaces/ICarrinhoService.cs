using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface ICarrinhoService
    {
    
        void AdicionarProdutoCarrinho(Carrinho carrinho);

        // Lista os produtos no carrinho
        List<CarrinhoDTO> ListarProdutoCarrinho();

      
        void EditarProdutoCarrinho(Carrinho carrinho);

        
        void DeletarProdutoCarrinho(int id);
    }
}
