using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._03_Entidades.DTOS
{
    public class VendaDTO
    {
        
            public int Id { get; set; }
            public int IdCarrinho { get; set; }
            public List<ItemCarrinho> ItensCarrinho { get; set; } 

           
        public class ItemCarrinho
        {
            public int ProdutoId { get; set; }
            public string NomeProduto { get; set; }
            public decimal Preco { get; set; }
            public int Quantidade { get; set; }
        }

    }
}
