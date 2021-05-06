using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCare.Utils.ViewModel
{
    public class ProdutoViewModel
    {
		[Required (ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(30)]
        [Display( Name = "Nome do produto")]
		public string NomeProduto { get; set; }

		[Required (ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(500)]
        [Display( Name = "Descrição")]
		public string Descricao { get; set; }
		
		[Required (ErrorMessage = "O campo {0} é obrigatório")]
        [Display( Name = "Preço")]
		public double Preco { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[Display(Name = "Quantidade")]
		public int Quantidade { get; set; }


		[Required(ErrorMessage = "O campo é obrigatório")]
		[Display(Name = "Status do estoque")]
		public string EstoqueStatus { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[Display(Name = "Largura")]
		public int Largura { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[Display(Name = "Altura")]
		public int Altura { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[Display(Name = "Largura")]
		public int Comprimento { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[Display(Name = "Dimensões")]
		public int Peso { get; set; }


		[Required (ErrorMessage = "O campo {0} é obrigatório")]
        [Display( Name = "Categoria")]
		public int IdCategoria { get; set; }

		public IFormFile? Imagem1 { get; set; }
		public IFormFile? Imagem2 { get; set; }
		public IFormFile? Imagem3 { get; set; }

	}
}