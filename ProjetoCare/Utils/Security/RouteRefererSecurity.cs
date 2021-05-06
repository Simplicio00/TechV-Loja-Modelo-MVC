using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.Security
{
	public class RouteRefererSecurity : Attribute, IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext context)
		{

		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			string referer = context.HttpContext.Request.Headers["Referer"].ToString();

			if (string.IsNullOrEmpty(referer))
			{
				context.Result = new RedirectToActionResult("index", "home", null);
			}
			else
			{
				Uri uri = new Uri(referer);
				string hostReferer = uri.Host;
				string hostServer = context.HttpContext.Request.Host.Host;
				if (hostReferer != hostServer)
				{
					context.Result = new RedirectToActionResult("index", "home", null);
				}
			}
		}
	}
}
