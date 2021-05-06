using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using CorreiosService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCare.Utils.Service;
using Data.Resources.Interfaces;

namespace ProjetoCare.Controllers
{
	[Route("[controller]")]
	[ApiController]
	[Produces("application/json")]
	public class DefaultController : ControllerBase
	{
		ICanal cn;
		public DefaultController(ICanal cn)
		{
			this.cn = cn;
		}

		/// <summary>
		/// Consulta rápida de endereço por CEP através da API dos correios
		/// </summary>
		/// <param name="cep">endereço de CEP do usuário</param>
		/// <returns>Retorna um JSON com o endereço buscado</returns>
		[HttpGet("GetAddress/{cep}")]
		public IActionResult GetAddress([FromRoute] string cep) => Ok(Correios.GetCEP(cep));


		/// <summary>
		/// Busca o histórico das conversações
		/// </summary>
		/// <param name="id">Identificação do canal de comunicação</param>
		/// <returns>Retorna um JSON com o histórico</returns>
		[HttpGet("GetHistory/{id}")]
		public async Task<IActionResult> History([FromRoute] string id) => Ok(await cn.ListChat(int.Parse(id)));

	}
}
