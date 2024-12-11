using Dapper.Contrib.Extensions;


namespace TrabalhoFinal._03_Entidades
{
   
    public class Carrinho
    {
        public int Id { get; set; }  // ID do Carrinho
        public int IdPessoa { get; set; }
        public int IdProduto { get; set; }
        public List<Item> Itens { get; set; } // Lista de Itens no Carrinho

       
        
        
    }

}
