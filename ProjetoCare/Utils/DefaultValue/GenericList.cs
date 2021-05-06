using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.DefaultValue
{
	public class GenericList
	{
		public static List<SelectListItem> FilterDefaultPrices 
		{ 
			get => new List<SelectListItem>(){
					new SelectListItem(){Text="R$ 01,00 - R$ 05,00", Value="1-5"},
					new SelectListItem(){Text="R$ 06,00 - R$ 10,00", Value="6-10"},
					new SelectListItem(){Text="R$ 11,00 - R$ 15,00", Value="11-15"},
					new SelectListItem(){Text="R$ 16,00 - R$ 20,00", Value="16-20"}
				};
		}

		public static List<SelectListItem> StatusCompra { 
			get => 	new List<SelectListItem>(){
					new SelectListItem(){Text="Em espera"},
					new SelectListItem(){Text="Cancelado/expirado"},
					new SelectListItem(){Text ="Concluído"},
				};
		 }	

	}
}
