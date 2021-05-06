using CorreiosService;
using ProjetoCare.Utils.ViewModel;
using System.Collections.Generic;

namespace ProjetoCare.Utils.Service
{
	public class Correios
	{
		const string defaulterror = "Não encontrado";


		/// <summary>
		/// Busca o endereço pelo CEP
		/// </summary>
		/// <param name="cep">cep inserido</param>
		/// <returns>retorna o endereço de CEP</returns>
		public static Endereco GetCEP(string cep)
		{
			AtendeClienteClient cl = new AtendeClienteClient();

			try
			{
				var address = cl.consultaCEPAsync(cep).Result.@return;

				return new Endereco
				{
					Bairro = address.bairro,
					Cidade = address.cidade,
					UF = address.uf,
					Complemento = address.complemento2,
					End = address.end
				};
			}
			catch (System.Exception ex)
			{
				return new Endereco()
				{
					Bairro = defaulterror,
					Cidade = defaulterror,
					UF = defaulterror,
					LogError = ex.Message.ToString()
				};
			}

		}
	}
}
