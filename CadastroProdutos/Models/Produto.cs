using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CadastroProdutos.Models
{
    [Table("produtos", Schema = "public")]
    public class Produto
    {
        [Key]
        [Column("id")]
        public int? ID { get; private set; } = null;
        [Column("nome")]
        public string Nome { get; set; }
        [Column("preco")]
        public double Preco { get; set; }

        [Column("cat_id")]
        public int CategoriaID { get; set; }
        [ForeignKey(nameof(CategoriaID))]
        public Categoria Categoria { get; set; }
    }
}
