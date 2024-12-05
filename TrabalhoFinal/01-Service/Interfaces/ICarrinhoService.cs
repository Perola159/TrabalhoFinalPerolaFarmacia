using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface ICarrinhoService
    {
        void AdicionarProdutoCarrinho(Carrinho C);
        List<CarrinhoDTO> ListarProdutoCarrinho();  
        void EditarProdutoCarrinho(Carrinho c);
       void DeletarProdutoCarrinho(int id); 
    }

}
