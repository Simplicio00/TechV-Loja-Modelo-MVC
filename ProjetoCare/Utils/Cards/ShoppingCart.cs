using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjetoCare.Utils.ViewModel;

namespace ProjetoCare.Utils.Cards
{
	public class ShoppingCart
	{
		private string key = "Carrinho";
		Cookie.Cookie cookie;

		public ShoppingCart(Cookie.Cookie cookie)
		{
			this.cookie = cookie;
		}


		/// <summary>
		/// Salva a lista
		/// </summary>
		/// <param name="list"></param>
		public void Save(List<ProductCart> list)
		{
			cookie.Insert(key, JsonConvert.SerializeObject(list));
		}


		/// <summary>
		/// Insere unidade 
		/// </summary>
		/// <param name="product"></param>
		public void Insert(ProductCart product)
		{
			List<ProductCart> products;

			if(cookie.Exists(key))
			{
				products = Search();
				var item = products.FirstOrDefault(a => a.IdProduto == product.IdProduto);

				if(item == null)
				{
					products.Add(product);
				}
				else
				{
					item.QuantidadeCarrinho += 1;
				}
			}
			else
			{
				products = new List<ProductCart>();
				products.Add(product);	
			}

			Save(products);
		}

		/// <summary>
		/// Remove unidade 
		/// </summary>
		/// <param name="product"></param>
		/// <returns></returns>
		public async Task RemoveUnit(ProductCart product)
		{

			if (cookie.Exists(key))
			{
				List<ProductCart> products;

				products = Search();

				var updatedProduct = products.FirstOrDefault(a => a.IdProduto == product.IdProduto);

				if (updatedProduct.QuantidadeCarrinho > 1)
				{
					updatedProduct.QuantidadeCarrinho -= 1; 
				}

				await Task.Delay(500);

				Save(products);
			}

		}

		/// <summary>
		/// Remove produto 
		/// </summary>
		/// <param name="product"></param>
		public void Remove(ProductCart product)
		{
			var list = Search();

			ProductCart item = list.FirstOrDefault(a => a.IdProduto == product.IdProduto);

			if (item != null)
			{
				list.Remove(item);
				Save(list);
			}
		}

		/// <summary>
		/// Busca de produtos no carrinho
		/// </summary>
		/// <returns></returns>
		public List<ProductCart> Search()
		{
			if(cookie.Exists(key))
			{
				return JsonConvert.DeserializeObject<List<ProductCart>>(cookie.Search(key));
			}

			return new List<ProductCart>();
		}




	}
}
