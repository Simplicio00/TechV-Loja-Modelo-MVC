using Data.Resources.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProjetoCare.Utils.Security;
using ProjetoCare.Utils.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Areas.Administrador.Controllers
{
	[Area("Administrador")]
	public class ChatController : Controller
	{
		IUsuario _user;
		public ChatController(IUsuario _user)
		{
			this._user = _user;
		}

		[HttpGet("user")]
		public async Task<IActionResult> Index()
		{
			var users = new List<UserInfoViewModel>();
			foreach (var item in await _user.List())
			{
				users.Add(new UserInfoViewModel(){
					Id = item.IdUsuario,
					Nome = item.Nome,
					Email = item.Email
				});	
			}

			return View(users);
		}



		[HttpGet("user/{id}")]
		[RouteRefererSecurity]
		public async Task<IActionResult> GET([FromRoute] int id)
		{
			var user = await _user.SearchById(id);

			return View(new UserInfoViewModel(){
				Nome = user.Nome,
				Email = user.Email,
				Id = user.IdUsuario,
				CanalId = user.CanalId
			});
		}
	}
}
