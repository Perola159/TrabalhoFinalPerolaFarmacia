using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades.DTOS
{
    public class CarrinhoDTO
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        public int IdProduto { get; set; }
        public Produtos Produto { get; set; }
    }
}
