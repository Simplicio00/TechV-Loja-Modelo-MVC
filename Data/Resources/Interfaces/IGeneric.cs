using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Resources.Interfaces
{
	public interface IGeneric<Entity> where Entity : class 
	{
		Task<List<Entity>> List();
		Task Add(Entity objeto);
		Task Update(Entity objeto);
		Task Delete(int id);
		Task<Entity> SearchById(int id);
	}
}
