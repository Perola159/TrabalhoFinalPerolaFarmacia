using TrabalhoFinal._03_Entidades;

public class VendaComCarrinhoDTO
{
    public int Id { get; set; }
    public int IdCarrinho { get; set; }
    public List<ItemCarrinho> ItensCarrinho { get; set; }
    public int IdVenda { get; set; }

}


