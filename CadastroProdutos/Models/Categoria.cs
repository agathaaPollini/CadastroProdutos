using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CadastroProdutos.Models
{
    [Table("categorias", Schema = "public")]
    public class Categoria
    {
        [Key]
        [Column("id")]
        public int ID { get; private set; }
        [Column("nome")]
        public string Nome { get; set; } = "";

        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
