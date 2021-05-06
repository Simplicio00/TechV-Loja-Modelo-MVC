using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Imagem
{
	public class Imagem
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdImagem { get; set; }

		[Required]
		public string ImagemCaminho { get; set; }


		[Required]
		public int IdProduto { get; set; }

		[ForeignKey("IdProduto")]
		public virtual Classes.Produto.Produto ProdutoNavigation { get; set; }
		

	}
}