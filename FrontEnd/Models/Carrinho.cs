using System.Collections.Generic;



namespace TrabalhoFinal._03_Entidades
{
    public class Carrinho
    {
        public int Id { get; set; } // ID do carrinho
        public int ProdutoId { get; set; }
        public int UsuarioId { get; set; }
       
        public List<ItemCarrinho> Itens { get; set; } // Lista de itens no carrinho

        public Carrinho()
        {
            Itens = new List<ItemCarrinho>();
        }

        public class ItemCarrinho
        {
            public int ProdutoId { get; set; } // ID do produto
            public string NomeProduto { get; set; } // Nome do produto
            public decimal Preco { get; set; } // Preço do produto
            public int Quantidade { get; set; } // Quantidade
        }
    }
}
