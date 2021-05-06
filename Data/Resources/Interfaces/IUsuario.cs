using Classes.Usuario;
using System.Threading.Tasks;

namespace Data.Resources.Interfaces
{
	public interface IUsuario : IGeneric<Usuario>
	{
		Task<Usuario> Login(string email, string password);
	}
}
