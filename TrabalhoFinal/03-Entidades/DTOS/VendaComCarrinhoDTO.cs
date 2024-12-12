namespace TrabalhoFinal._03_Entidades.DTOS
{
    public class VendaComCarrinhoDTO
    {
        public int Id { get; set; }
        public int IdCarrinho { get; set; }
        public List<Item> ItensCarrinho { get; set; } // Agora inclui os itens
        public int IdVenda { get; set; }
    }
}
