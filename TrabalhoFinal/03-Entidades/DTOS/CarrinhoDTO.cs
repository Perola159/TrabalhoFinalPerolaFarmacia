﻿namespace TrabalhoFinal._03_Entidades.DTOS
{
    public class CarrinhoDTO
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int IdProduto { get; set; }
        public List<Item> Itens { get; set; } // Adicionar itens no DTO
    }
}
