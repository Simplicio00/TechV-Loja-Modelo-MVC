using Classes.Estoque;
using Data.Contexts;
using Data.Resources.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Resources.Repositories
{
	public class EstoqueRepository : IEstoque
	{
		DBContext _ctx;
		public EstoqueRepository(DBContext _ctx)
		{
			this._ctx = _ctx;
		}
		public async Task Add(Estoque objeto)
		{
			try
			{
				await _ctx.AddAsync(objeto);
				await _ctx.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Estoque>> List() => await _ctx.Estoque.Include(a => a.Produto).ToListAsync();

		public async Task<Estoque> SearchById(int id) => await _ctx.Estoque.Include(a => a.Produto).FirstOrDefaultAsync(a => a.IdEstoque == id);

		public async Task Update(Estoque objeto)
		{
			try
			{
				_ctx.Update(objeto);
				await _ctx.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
