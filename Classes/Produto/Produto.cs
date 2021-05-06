using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Produto
{
	public class Produto
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdProduto { get; set; }

		[Required]
		[StringLength(35)]
		public string NomeProduto { get; set; }

		[Required]
		[DataType(DataType.Text)]
		[StringLength(500)]
		public string Descricao { get; set; }
		
		[Required]
		public double Preco { get; set; }
		
		[Required]
		public DateTime DataRegistro { get; set; }

		public int Comprimento { get; set; }

		public int Largura { get; set; }

		public int Altura { get; set; }

		public int Peso { get; set; }

		public bool Status { get; set; }


		[Required]
		public int IdCategoria { get; set; }


		[ForeignKey("IdCategoria")]
		public virtual Categoria.Categoria IdCategoriaNavigation { get; set; }

		[Required]
		public int IdEstoque { get; set; }

		[ForeignKey("IdEstoque")]
		public virtual Estoque.Estoque IdEstoqueNavigation { get; set; }




		public virtual ICollection<Imagem.Imagem> Imagens { get; set; }


		//public virtual ICollection<Registro.Registro> Registros { get; set; }  

	}
}
