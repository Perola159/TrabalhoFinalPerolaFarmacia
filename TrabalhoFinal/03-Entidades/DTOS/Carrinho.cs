using TrabalhoFinal._03_Entidades;

public class Carrinho
{
    public int Id { get; set; }
    public int IdPessoa { get; set; }
    public List<Item> Itens { get; set; }

    // Para acessar os produtos via itens:
    public List<Produtos> Produtos => Itens.Select(i => i.Produto).ToList();

    public int IdProduto { get; internal set; }
}
