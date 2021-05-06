using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.ViewModel
{
	public class UserLoginViewModel
	{
		[Required(ErrorMessage = "Insira um email para continuar!")]
		[DataType(DataType.EmailAddress)]
		[StringLength(30)]
		public string Email { get; set; }

		[Required(ErrorMessage = "Insira a senha")]
		[DataType(DataType.Password)]
		[StringLength(30)]
		public string Senha { get; set; }
	}
}