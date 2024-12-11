

using Dapper.Contrib.Extensions;

namespace TrabalhoFinal._03_Entidades
{
    public class MetodoPagamento
    {
        public int Id { get; set; }         
        public string Nome { get; set; }  
        public string Tipo { get; set; }    //  Cartão, Boleto, Pix)
        public bool Ativo { get; set; }  
        public decimal TaxaTransacao { get; set; } // Taxa de transação, se TIVER
    }
}

