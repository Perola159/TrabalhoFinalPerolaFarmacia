namespace FrontEnd.Models;

public class Carrinho
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int ProdutoId { get; set; }
    public Carrinho Itens { get; set; }


}
