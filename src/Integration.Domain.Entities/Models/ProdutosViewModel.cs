using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Integration.Domain.Entities.Models
{
    public class ProdutosViewModel
    {
        [Key]
        public int? Id { get; set; }

        public string Descricao { get; set; }

        public Decimal? Preco { get; set; }
    }
}
