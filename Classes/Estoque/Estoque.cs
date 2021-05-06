using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Estoque
{
	public class Estoque
	{

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdEstoque { get; set; }

		[Required]
		public int Quantidade { get; set; }

		[Required]
		public string Status { get; set; }

		public virtual ICollection<Classes.Produto.Produto> Produto { get; set; }

	}
}