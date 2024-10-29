using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface IProdutoService
    {
        void AdicionarProduto(Produtos P);
        List<Produtos> ListarProduto();
        Produtos BuscarProdutosPorId(int id);
        void EditarProduto(Produtos P);
        void RemoverProduto(int id);
    }
}
