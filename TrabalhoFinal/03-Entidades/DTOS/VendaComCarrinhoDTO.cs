using TrabalhoFinal._03_Entidades;

public class VendaComCarrinhoDTO
{
    public int Id { get; set; }
    public int IdCarrinho { get; set; }
    public List<ItemCarrinho> ItensCarrinho { get; set; } // Supondo que "ItemCarrinho" seja uma entidade representando os itens do carrinho

    // Adicione mais propriedades conforme necessário
}


