using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoCare.Utils.Session;

namespace ProjetoCare.Areas.Administrador.Controllers
{
    [Area("administrador")]
    public class ConfController : Controller
    {
		private readonly UserSession _uss;

        public ConfController(UserSession _uss)
        {
            this._uss = _uss;
        }
        
        
        public IActionResult Logout()
		{
			_uss.LogoutA();

            return RedirectToAction("index","home", new { area = "" });
		}
    }
}