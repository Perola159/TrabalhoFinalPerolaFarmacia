
using FrontEnd.Models;

namespace FrontEnd
{
    public class ReadCarrinhoDTO
    {
        public int Id { get; set; }
        public Pessoa Usuario { get; set; }
        public Produto Produto { get; set; }

        public override string ToString()
        {
            return $"Usuario {Usuario.Nome} - Produto : {Produto.Nome} - Preço: {Produto.Preco}";
        }

    }
}
