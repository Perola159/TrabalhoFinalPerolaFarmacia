namespace TrabalhoFinal._03_Entidades
{
    public class Item
    {
        public int Id { get; set; } // Id do item
        public string Produto { get; set; }
        public int IdProduto { get; set; } // Id do produto
        public int Quantidade { get; set; } // Quantidade do produto no carrinho
        public decimal PrecoUnitario { get; set; } // Preço unitário do produto
        public decimal Total => Quantidade * PrecoUnitario; // Total do item (quantidade * preço unitário)
    }
}
