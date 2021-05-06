using Classes.Historico;
using Classes.Produto;
using Classes.Registro;
using Data.Resources.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProjetoCare.Utils.Cards;
using ProjetoCare.Utils.Payment;
using ProjetoCare.Utils.Security;
using ProjetoCare.Utils.Session;
using ProjetoCare.Utils.Validations;
using ProjetoCare.Utils.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Controllers
{
	public class PagamentoController : Controller
	{
		private const bool IsAdmin = false;
		private readonly ShoppingCart sp;
		private readonly BoletoPDFGenerator bl;
		private readonly IProduto pd;
		private readonly ISystemlog sl;
		private readonly UserSession usr;

		public PagamentoController(ShoppingCart sp, IProduto pd, ISystemlog sl, UserSession usr, BoletoPDFGenerator bl)
		{
			this.sp = sp;
			this.pd = pd;
			this.sl = sl;
			this.usr = usr;
			this.bl = bl;
		}


		/// <summary>
		/// Página de pagamento por boleto
		/// </summary>
		/// <returns>Redireciona para a página de pagamento por boleto</returns>
		[HttpGet]
		[RouteRefererSecurity]
		[RoleSecurityRoute(adm = IsAdmin)]
		public async Task<IActionResult> Index() 
		{
			List<ProductCart> ProductsInCart = new List<ProductCart>();

			foreach (var item in sp.Search())
			{
				var produto = await pd.SearchById(item.IdProduto);

				ProductsInCart.Add(new ProductCart()
				{
					IdProduto = produto.IdProduto,
					Imagem = produto.Imagens.FirstOrDefault().ImagemCaminho,
					NomeProduto = produto.NomeProduto,
					Preco = produto.Preco,
					QuantidadeCarrinho = item.QuantidadeCarrinho
				});
			}

			return View(ProductsInCart);
		} 
		


		/// <summary>
		/// Gera um modelo de boleto e registra no sistema os produtos recem adquiridos
		/// </summary>
		/// <returns>Redireciona o comprador para a consulta da transacao recem gerada</returns>
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> GerarBoleto()
		{
			var codigo = Validations.GenerateTransactionCode();
			double total = 0;
			var produtos = new List<ProductCart>();
			var usuario = usr.GetUser();

			
			foreach (var item in sp.Search())
			{
				var pdt = await pd.SearchById(item.IdProduto);

				total += pdt.Preco * item.QuantidadeCarrinho;

				produtos.Add(new ProductCart
				{
					NomeProduto = pdt.NomeProduto,
					Preco = pdt.Preco,
					QuantidadeCarrinho = item.QuantidadeCarrinho
				});
			}


			int id = await sl.Post(
					new HistoricoCompra()
					{
						DataEmissao = DateTime.Now,
						Codigo = codigo,
						Status = "Em espera",
						Total = total,
						IdUsuario = usuario.Id
					});

			foreach (var item in Validations.UnityCount(produtos))
			{
				await sl.Post(new Registro()
				{
					IdHistoricoCompra = id,
					Produto = item
				});
			}

			await bl.GerarBoletoPDF(usuario, codigo, total);

			return RedirectToAction("transacao", "user", new { codigo });
			
		}



	}
}