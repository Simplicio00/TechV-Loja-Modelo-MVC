using Newtonsoft.Json;
using ProjetoCare.Utils.ViewModel;

namespace ProjetoCare.Utils.Autentication
{
	public class Autentication
	{
		private readonly string key = "projetoCareAuthKey@3845x";
		private readonly Session.Session _session;
 		public Autentication(Session.Session _session)
		{
			this._session = _session;
		}

		/// <summary>
		/// Cadastra o usuario na sessao
		/// </summary>
		/// <param name="usr"></param>
		public void Logon(UserInfoViewModel usr)
		{
			string JsonCatch = JsonConvert.SerializeObject(usr);
			_session.Insert(key, JsonCatch);
		}


		/// <summary>
		/// Busca o usuario na sessao
		/// </summary>
		/// <returns></returns>
		public UserInfoViewModel GetUser()
		{
			string jsonUser = _session.Search(key);
			if (_session.Exists(key))
			{
				return JsonConvert.DeserializeObject<UserInfoViewModel>(jsonUser);
			}

			return null;
		}


		/// <summary>
		/// Faz o logout
		/// </summary>
		public void Logout()
		{
			_session.Remove(key);
		}


	}
}
