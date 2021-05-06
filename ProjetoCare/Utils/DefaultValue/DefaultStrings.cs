using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ProjetoCare.Utils.DefaultValue
{
    public class DefaultStrings
    {
        public static string EmailRegexProp { get => "@.";  }

        public static string PerQuantityProperty { get => "PD"; }

        public static string PerAlfaProperty { get => "AF"; }

        public static List<SelectListItem> EstoqueDefaultProperty { 
            get => 
                new List<SelectListItem>()
                { 
                    new SelectListItem {Text = "Disponível"},
                    new SelectListItem {Text = "Em espera"},
                    new SelectListItem {Text = "Indisponível"}
                };  
        }

        public enum StatusFilters
		{
            BadRequest = 400,
            NotAuthorizedRequest = 401,
            ForbiddenRequest = 403,
            NotFoundRequest = 404,
            NotAllowedRequest = 405,
            ServiceIsNotAvaliable = 503
		}

    }
}