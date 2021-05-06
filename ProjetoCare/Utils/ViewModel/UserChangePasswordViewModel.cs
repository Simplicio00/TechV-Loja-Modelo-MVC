using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.ViewModel
{
	public class UserChangePasswordViewModel
	{

		[Required(ErrorMessage = "Insira a senha")]
		[DataType(DataType.Password)]
		[StringLength(30)]
		public string Senha { get; set; }


		[Display(Name = "Confirme a senha")]
		[Required(ErrorMessage = "A senha precisa coincidir")]
		[DataType(DataType.Password)]
		[StringLength(30)]
		[Compare(nameof(Senha))]
		public string ConfirmarSenha { get; set; }
	}
}
