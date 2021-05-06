using Classes.Canal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Resources.Interfaces
{
	public interface ICanal : IGeneric<Canal>, IGeneric<CanalUser>
	{
		Task<List<CanalUser>> ListChat(int id);
	}
}
