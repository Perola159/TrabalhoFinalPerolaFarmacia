using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades.DTOS
{
    public class CreateProdutoDTO
    {
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Produtos produtos { get; set; }

        public List <Produtos> prod { get; set; }
    }
}
