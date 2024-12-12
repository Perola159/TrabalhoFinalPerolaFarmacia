using TrabalhoFinal._03_Entidades;

public class Venda
{
    public int Id { get; set; }
    public int IdCarrinho { get; set; }
    public List<Item> Itens { get; set; }// Lista de itens que foram comprados na venda
}

public class ItemVenda
{
    public int ProdutoId { get; set; }   // ID do produto comprado
    public int Quantidade { get; set; }  // Quantidade comprada
    public double Preco { get; set; }    // Preço do produto
    public string NomeProduto { get; set; }  // Nome do produto
}
