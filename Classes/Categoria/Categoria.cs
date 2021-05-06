using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Categoria
{
	public class Categoria
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdCategoria { get; set; }


		[Required]
		[StringLength(30)]
		public string NomeCategoria { get; set; }

		public virtual ICollection<Classes.Produto.Produto> Produto { get; set; }

	}
}
