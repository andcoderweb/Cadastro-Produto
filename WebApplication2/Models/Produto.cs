using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{

    [Table("Produto")]
    public class Produto
    {
        [Display(Description ="Código")]
        public int Id { get; set; }
        [Display(Description = "Descrição do Produto")]
        public string Descricao { get; set; }
    }
}
