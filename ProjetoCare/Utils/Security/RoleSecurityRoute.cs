using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProjetoCare.Utils.Session;
using ProjetoCare.Utils.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.Security
{
	[AttributeUsage(AttributeTargets.Method)]
	public class RoleSecurityRoute : Attribute, IAsyncAuthorizationFilter
	{
		public bool adm { get; set; }
		public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
		{
			if (adm.Equals(true))
			{
				await Task.Delay(100);
				var myuser = context.HttpContext.Session.Keys.FirstOrDefault(a => a == "adminkey");
				//Verifica se o usuário da sessão existe
				if (myuser == null)
				{
					context.Result = new RedirectToActionResult("index", "home", new { area = "" });
				}
			}
			else
			{
				await Task.Delay(100);
				var myuser = context.HttpContext.Session.Keys.FirstOrDefault(a => a == "userkey");
				//Verifica se o usuário da sessão existe
				if (myuser == null)
				{
					context.Result = new RedirectToActionResult("index", "home", null);
				}
			}
			
		}
	}
}
