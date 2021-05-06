using Classes.Historico;
using Data.Resources.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProjetoCare.Utils.Security;
using System.Threading.Tasks;

namespace ProjetoCare.Areas.Administrador.Controllers
{
	[Area("Administrador")]
	public class HomeController : Controller
	{
		private readonly ISystemlog _log;
		const bool IsAdmin = true;
		public HomeController(ISystemlog _log)
		{
			this._log = _log;
		}


		[RoleSecurityRoute(adm = IsAdmin)]
		public async Task<IActionResult> Index() => View(await _log.Syslog());




		[HttpGet("{codigo}")]
		[RoleSecurityRoute(adm = IsAdmin)]
		public async Task<IActionResult> TRANSACTION([FromRoute] string codigo) => View(await _log.GetHistory(codigo)); 


		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> TRANSACTIONCHANGE(HistoricoCompra newstatus)
		{
			var transaction = await _log.GetHistory(newstatus.Codigo);

			transaction.Status = newstatus.Status;

			await _log.UpdateStatus(transaction);

			return RedirectToAction(nameof(TRANSACTION), new { codigo = newstatus.Codigo });	
		}



			
	}
}
