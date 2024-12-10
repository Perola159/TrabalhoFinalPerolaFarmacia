using Dapper.Contrib.Extensions;


namespace TrabalhoFinal._03_Entidades
{
   
    public class Carrinho
    {
        public int Id { get; set; }  // ID do Carrinho
        public int IdPessoa { get; set; }
        public int IdProduto { get; set; }
        public List<Item> Itens { get; set; } // Lista de Itens no Carrinho

        public Carrinho(int id)
        {
            Id = id;
            Itens = new List<Item>(); // Inicializa a lista de itens do carrinho
        }
    }

    
    public class Item
    {
        public int ProdutoId { get; set; } 
        public int Quantidade { get; set; } 
        public decimal Preco { get; set; } 
    }


}
