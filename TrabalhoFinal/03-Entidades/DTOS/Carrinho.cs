using TrabalhoFinal._03_Entidades;

public class Carrinho
{
    public int Id { get; set; }
    public int IdPessoa { get; set; }
    public List<Item> Itens { get; set; }

  

    public int IdProduto { get; internal set; }
}
