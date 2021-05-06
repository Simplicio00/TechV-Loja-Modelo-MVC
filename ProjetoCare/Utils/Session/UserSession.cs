using Newtonsoft.Json;
using ProjetoCare.Utils.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.Session
{
	public class UserSession 
	{
		private readonly string key = "userkey";
		private readonly string admnkey = "adminkey";
		Session session;
		public UserSession(Session session)
		{
			this.session = session;
		}

		/// <summary>
		/// logoff do sistema
		/// </summary>
		public void Logout() => session.Remove(key);


		
		public void LogoutA() => session.Remove(admnkey);


		/// <summary>
		/// Autenticacao de usuario no sistema
		/// </summary>
		/// <param name="usr">informacoes de usuario</param>
		public void Logon(UserInfoViewModel usr) => session.Insert(key, JsonConvert.SerializeObject(usr));


		/// <summary>
		/// Traz usuario logado
		/// </summary>
		/// <returns>retorna usuario logado</returns>
		public UserInfoViewModel GetUser()
		{
			string user = session.Search(key);

			if (session.Exists(key)) return JsonConvert.DeserializeObject<UserInfoViewModel>(user);

			return null;
		}


		/// <summary>
		/// Autenticacao de administrador
		/// </summary>
		/// <param name="usr">informacoes do adm</param>
		public void LogonAdmin(AdminInfoViewModel usr) => session.Insert(admnkey, JsonConvert.SerializeObject(usr));



		/// <summary>
		/// Traz o adm autenticado
		/// </summary>
		/// <returns>retorna adm autenticado</returns>
		public AdminInfoViewModel GetAdmin()
		{
			string adm = session.Search(admnkey);

			if (session.Exists(admnkey))
			{
				return JsonConvert.DeserializeObject<AdminInfoViewModel>(adm);
			}

			return null;

		}


	}
}
