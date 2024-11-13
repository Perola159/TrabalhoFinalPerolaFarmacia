using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades
{
    [Table("Produtos")]
    public class Produtos
    {
        public string Nome { get; set; }
        public int Preco { get; set; }
        public int Id { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
