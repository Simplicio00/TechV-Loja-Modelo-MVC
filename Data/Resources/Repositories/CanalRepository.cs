using Classes.Canal;
using Data.Contexts;
using Data.Resources.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Resources.Repositories
{
	public class CanalRepository : ICanal
	{
		DBContext _ctx;
		public CanalRepository(DBContext _ctx)
		{
			this._ctx = _ctx;
		}

		public async Task Add(Canal objeto)
		{
			await _ctx.Canal.AddAsync(objeto);
			await _ctx.SaveChangesAsync();
		}

		public async Task Add(CanalUser objeto)
		{
			await _ctx.CanalUser.AddAsync(objeto);
			await _ctx.SaveChangesAsync();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Canal>> List() => await _ctx.Canal.Include(a => a.CanalUser).AsTracking().ToListAsync();



		public async Task<List<CanalUser>> ListChat(int id) => await _ctx.CanalUser.AsTracking().Where(a => a.CanalId == id).OrderBy(a => a.IdMessage).ToListAsync();



		public Task<Canal> SearchById(int id)
		{
			throw new NotImplementedException();
		}

		public Task Update(Canal objeto)
		{
			throw new NotImplementedException();
		}

		public Task Update(CanalUser objeto)
		{
			throw new NotImplementedException();
		}

		Task<List<CanalUser>> IGeneric<CanalUser>.List()
		{
			throw new NotImplementedException();
		}

		Task<CanalUser> IGeneric<CanalUser>.SearchById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
