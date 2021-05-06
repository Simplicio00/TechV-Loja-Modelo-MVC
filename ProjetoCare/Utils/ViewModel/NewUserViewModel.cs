using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.ViewModel
{
	public class NewUserViewModel 
	{
		[Display(Name = "Nome")]
		[Required(ErrorMessage = "Um {0} nome é necessário")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Insira um email para continuar!")]
		[DataType(DataType.EmailAddress)]
		[StringLength(30)]
		public string Email { get; set; }

		[Required(ErrorMessage = "Insira a senha")]
		[DataType(DataType.Password)]
		[StringLength(30)]
		public string Senha { get; set; }

		[Display(Name = "Confirme a senha")]
		[Compare("Senha", ErrorMessage = "A senha não coincide")]
		[DataType(DataType.Password)]
		public string ConfirmarSenha { get; set; }

		[Display(Name = "CEP")]
		[Required(ErrorMessage = "O CEP é necessário")]
		public int CEP { get; set; }



	}
}
