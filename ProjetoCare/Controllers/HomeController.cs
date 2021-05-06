using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Classes.Produto;
using Data.Resources.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProjetoCare.Utils.Cards;
using ProjetoCare.Utils.Pagination;
using ProjetoCare.Utils.Validations;
using ProjetoCare.Utils.ViewModel;

namespace ProjetoCare.Controllers
{
	public class HomeController : Controller
	{
		private readonly IProduto _pd;
		private readonly ICategoria _ct;
		private readonly ShoppingCart sp;
		private readonly ILogger<HomeController> _logger;
		private const int PageSize = 12;


		public HomeController(ILogger<HomeController> logger, IProduto _pd, ICategoria _ct, ShoppingCart sp)
		{
			_logger = logger;
			this._pd = _pd;
			this._ct = _ct;
			this.sp = sp;
		}

		/// <summary>
		/// Página inicial do sistema com listagem de produtos
		/// </summary>
		/// <param name="categoria">Categoria do produto</param>
		/// <param name="prices">Precos dos produtos</param>
		/// <param name="pesquisa">Pesquisa</param>
		/// <param name="page">Pagina</param>
		/// <returns></returns>
		public async Task<IActionResult> Index(string? categoria, string? prices, string? pesquisa, int page = 1)
		{
			if (!string.IsNullOrEmpty(categoria))
				pesquisa = categoria;

			List<SelectListItem> categorias = new List<SelectListItem>();
			List<Produto> produtos = Validations.ProductIntegratedVerification(await _pd.List(), "Disponível", pesquisa, prices);

			if (page < 1)
			{
				page = 1;
			}

			 foreach (var item in await _ct.List())
            {
                categorias.Add(new SelectListItem(){ Text = item.NomeCategoria });
            }

			Pager pager = new Pager(produtos.Count, page, PageSize);
			TempData["MSGCTG"] = produtos.Count.ToString();
            ViewBag.Categorias = categorias;
			ViewBag.Pager = pager;


			await Task.Delay(300);

			return View(produtos.Skip(Validations.RecSkip(page, PageSize)).Take(pager.PageSize).ToList());

		}


		/// <summary>
		/// Página do produto com mais detalhes
		/// </summary>
		/// <param name="id">Id do produto</param>
		/// <returns>redireciona para a pagina do produto</returns>
		[HttpGet]
		public async Task<IActionResult> Produto(int id) => View(await _pd.SearchById(id));


		[HttpGet("cesta")]
		public async Task<IActionResult> Carrinho()
		{
			List<ProductCart> ProductsInterest = sp.Search();

			List<ProductCart> ProductsInCart = new List<ProductCart>();

			foreach (var item in ProductsInterest)
			{
				var produto = await _pd.SearchById(item.IdProduto);

				ProductCart product = new ProductCart()
				{
					IdProduto = produto.IdProduto,
					Imagem = produto.Imagens.FirstOrDefault().ImagemCaminho,
					NomeProduto = produto.NomeProduto,
					Preco = produto.Preco,
					QuantidadeCarrinho = item.QuantidadeCarrinho
				};

				ProductsInCart.Add(product);
			}

			return View(ProductsInCart);
		}



		/// <summary>
		/// Adiciona produto a cesta de compras
		/// </summary>
		/// <param name="id">Id do produto</param>
		/// <returns>Redireciona para a cesta de compras do usuario</returns>
		public async Task<IActionResult> AddToCart(int id)
		{
			var product = await _pd.SearchById(id);

			if(product == null)
			{
				return RedirectToAction(nameof(Index));
			}

			sp.Insert( 
				new ProductCart()
				{
					IdProduto = id,
					QuantidadeCarrinho = 1
				}
			);

			return RedirectToAction(nameof(Carrinho));
		}



		/// <summary>
		/// Remove produto por unidade na cesta do usuario
		/// </summary>
		/// <param name="id">id do produto</param>
		/// <returns>Atualiza a pagina da cesta de produtos</returns>
		public async Task<IActionResult> RemoveUnit(int id)
		{
			var product = sp.Search().FirstOrDefault(a => a.IdProduto == id);

			if (product == null)
			{
				return RedirectToAction(nameof(Index));
			}

			await sp.RemoveUnit(product);

			return RedirectToAction(nameof(Carrinho));
		}


		/// <summary>
		/// Remove o produto e todas as suas unidades da cesta
		/// </summary>
		/// <param name="id">id do produto</param>
		/// <returns>Atualiza a cesta</returns>
		public IActionResult Remove(int id)
		{
			var productList = sp.Search();

			var product = productList.FirstOrDefault(a => a.IdProduto == id);

			if (product == null)
			{
				return RedirectToAction(nameof(Carrinho));
			}

			sp.Remove(product);

			return RedirectToAction(nameof(Carrinho));

		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
