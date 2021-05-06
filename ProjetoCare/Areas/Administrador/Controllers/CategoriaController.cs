using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes.Categoria;
using Data.Resources.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProjetoCare.Utils.DefaultValue;
using ProjetoCare.Utils.Pagination;
using ProjetoCare.Utils.Security;
using ProjetoCare.Utils.Validations;

namespace ProjetoCare.Areas.Administrador.Controllers
{
    [Area("Administrador")]
    public class CategoriaController : Controller
    {
        private readonly ICategoria _cat;
        private const int MaxValueString = 25;
        private const int PageSize = 5;

        public CategoriaController(ICategoria _cat)
        {
            this._cat = _cat;
        }


        [RoleSecurityRoute(adm = true)]
        public async Task<IActionResult> Index(string? listagem, int pg = 1) 
        {

			List<Categoria> categorias = await _cat.List();

            if (listagem == DefaultStrings.PerAlfaProperty)
                categorias = Validations.AlfabeticListCategoria(categorias);
			

            if(listagem == DefaultStrings.PerQuantityProperty)
                categorias = Validations.MostProductsListCategoria(categorias);
			

            if(Validations.DefaultSingleStringValidation(listagem, MaxValueString).Equals(true) && listagem != DefaultStrings.PerAlfaProperty && listagem != DefaultStrings.PerQuantityProperty )
                categorias = await _cat.Search(listagem);
			
            
            if(pg < 1) pg = 1;


            Pager pager = new Pager(categorias.Count, pg, PageSize);



            ViewBag.Pager = pager;

            return View(categorias.Skip(Validations.RecSkip(pg, PageSize)).Take(pager.PageSize).ToList());

        }


        [RouteRefererSecurity]
        [RoleSecurityRoute(adm = true)]
        public async Task<IActionResult> CategoriaDetalhe(int id) => View(await _cat.SearchById(id));
	


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CategoriaDetalhe(Categoria categoria)
        {
            switch (Validations.DefaultSingleStringValidation(categoria.NomeCategoria, MaxValueString))
            {
                case true:
                    await _cat.Update(categoria);
                    TempData["MSG_1"] = "Categoria alterada com sucesso!";
                    await Task.Delay(1500);
                    return RedirectToAction(nameof(CategoriaDetalhe), categoria.IdCategoria); 
                
                default:
                    TempData["MSG_2"] = $"O valor inserido é nulo, acima de {MaxValueString-1} caracteres ou insuficiente!"; 
                    return RedirectToAction(nameof(CategoriaDetalhe), categoria.IdCategoria);
            }

        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastrar(string? valor)
        {
            if (valor != null && valor.StartsWith(">"))
                return RedirectToAction(nameof(Index), new { listagem = valor.Substring(1) } );

			else
			{
                if (Validations.DefaultSingleStringValidation(valor, MaxValueString).Equals(true))
                {
                    List<string> categorias = new List<string>();

                    foreach (var item in await _cat.List())
                    {
                        categorias.Add(item.NomeCategoria);
                    }

                    switch (Validations.ValueStringExists(categorias, valor))
                    {
                        case false:
                            await Task.Delay(1500);
                            await _cat.Add(new Categoria() { NomeCategoria = valor });
                            TempData["MSG_1"] = "Categoria criada com sucesso!";
                            return RedirectToAction(nameof(Index));

                        default:
                            TempData["MSG_2"] = $"A categoria que você inseriu já existe!";
                            return RedirectToAction(nameof(Index));
                    }
                }
                else
                {
                    TempData["MSG_2"] = $"O valor inserido é nulo, acima de {MaxValueString - 1} caracteres ou insuficiente!";
                    return RedirectToAction(nameof(Index));
                }
            }
        }


        public async Task<IActionResult> ExcluirCategoria(int id)
        {
            Categoria categoria = await _cat.SearchById(id);

			if (categoria.Equals(null))
			{
                return RedirectToAction(nameof(Index));
            }

            if (Validations.CategoriaContainProduct(categoria).Equals(false))
            {
                await _cat.Delete(id);
                TempData["MSG_1"] = "Categoria excluída com sucesso!";

                return RedirectToAction(nameof(Index));
            }

            TempData["MSG_2"] = "A categoria requisitada para exclusão possui produtos, desafilie-os da categoria antes de removela!";

            return RedirectToAction(nameof(Index));

        }



    }
}