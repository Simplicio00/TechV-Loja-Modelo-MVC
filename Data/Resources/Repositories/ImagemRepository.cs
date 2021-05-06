using Classes.Imagem;
using Data.Contexts;
using Data.Resources.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Resources.Repositories
{
	public class ImagemRepository : I_IMG
	{
		DBContext _db;

		public ImagemRepository(DBContext _db)
		{
			this._db = _db;
		}

		public async Task Add(Imagem objeto)
		{
			try
			{
				await _db.AddAsync(objeto);
				await _db.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task Delete(int id)
		{
			try
			{
				_db.Imagem.Remove(await SearchById(id));
				await _db.SaveChangesAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public Task<List<Imagem>> List()
		{
			throw new NotImplementedException();
		}

		public async Task<Imagem> SearchById(int id) => await _db.Imagem.FirstOrDefaultAsync(a => a.IdImagem == id);

		public async Task Update(Imagem objeto)
		{
			try
			{
				_db.Update(objeto);
				await _db.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


	}
}
