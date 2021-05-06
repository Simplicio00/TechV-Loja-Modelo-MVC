using Classes.Canal;
using Classes.Usuario;
using Data.Resources.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProjetoCare.Utils.Security;
using ProjetoCare.Utils.Session;
using ProjetoCare.Utils.Validations;
using ProjetoCare.Utils.ViewModel;
using System.Threading.Tasks;

namespace ProjetoCare.Controllers
{
	public class UserController : Controller
	{
		private readonly IUsuario user;
		private readonly UserSession _uss;
		private readonly ISystemlog sl;
		private readonly ICanal cn;
		private readonly IConfiguration _cf;
		public const bool IsAdmin = false;
		public UserController(UserSession _uss, IUsuario user, ISystemlog sl, ICanal cn, IConfiguration _cf)
		{
			this._uss = _uss;
			this.user = user;
			this.sl = sl;
			this.cn = cn;
			this._cf = _cf;
		}


		/// <summary>
		/// Pagina de login
		/// </summary>
		/// <returns>Redireciona para a pagina de login</returns>
		[RouteRefererSecurity]
		[HttpGet("login")]
		public IActionResult Index() => View();
		

		/// <summary>
		/// Acao de autenticacao no sistema
		/// </summary>
		/// <param name="login">credenciais de autenticacao</param>
		/// <returns>redireciona para o perfil</returns>
		[HttpPost]
		[Route("login")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Index(UserLoginViewModel login)
		{

			if (ModelState.IsValid)
			{

				if (login.Email == _cf["administrador:adm"] && login.Senha == _cf["administrador:admpw"])
				{
					_uss.LogonAdmin(new AdminInfoViewModel()
					{
						Nome = _cf["administrador:nome"].ToString(),
						Code = _cf["administrador:code"].ToString()
					});

					return RedirectToAction("index", "home", new { area = "administrador" });
				}

				var usr = await user.Login(login.Email, login.Senha);

				if (usr != null)
				{
					_uss.Logon(new UserInfoViewModel()
					{
						Id = usr.IdUsuario,
						Nome = usr.Nome,
						CEP = usr.CEP,
						Email = usr.Email,
						CanalId = usr.CanalId
					});

					return RedirectToAction("perfil", "user");
				}

				TempData["MSGE"] = "Erro!.. Verifique suas credenciais de acesso";
			}


			return View(login);
		}


		/// <summary>
		/// Tela de cadastro
		/// </summary>
		/// <returns>redireciona para a tela de cadastro</returns>
		[RouteRefererSecurity]
		[HttpGet("login/cadastrar")]
		public IActionResult Cadastrar() => View();



		/// <summary>
		/// acao de cadastro de usuario
		/// </summary>
		/// <param name="newUser">usuario a ser cadastrado</param>
		/// <returns>redireciona para a pagina de login</returns>
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Route("login/cadastrar")]
		public async Task<IActionResult> Cadastrar(NewUserViewModel newUser)
		{
			if (ModelState.IsValid && Validations.IsEmailValid(newUser.Email).Equals(true))
			{
				if (Validations.EmailExists(newUser.Email, await user.List()).Equals(true))
				{
					TempData["MSGE"] = "O E-mail em questão já está cadastrado no sistema";

					return View(newUser);
				}

				Canal canal = new Canal();

				await cn.Add(canal);

				await user.Add(new Usuario { 
					Nome = newUser.Nome,
					Email = newUser.Email,
					Senha = newUser.Senha,
					Status = true,
					CanalId = canal.CanalId,
					CEP = newUser.CEP.ToString()
				});


				TempData["MSGS"] = "Cadastrado com sucesso";

				return RedirectToAction(nameof(Index));

			}

			return View(newUser);
		}


		/// <summary>
		/// pagina do perfil
		/// </summary>
		/// <returns>redireciona para a pagina de perfil</returns>
		[HttpGet("perfil")]
		[RoleSecurityRoute(adm = IsAdmin)]
		public IActionResult Perfil() => View();


		/// <summary>
		/// pagina de alterar senha
		/// </summary>
		/// <returns>redireciona para a pagina de alterar senha</returns>
		[HttpGet("perfil/senha")]
		[RoleSecurityRoute(adm = IsAdmin)]
		public IActionResult AlterarSenha() => View();


		/// <summary>
		/// acao de alterar senha
		/// </summary>
		/// <param name="pw">nova senha</param>
		/// <returns>atualiza a pagina de alterar senha</returns>
		[HttpPost("perfil/senha")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AlterarSenha(UserChangePasswordViewModel pw)
		{
			if (ModelState.IsValid)
			{
				var myuser = await user.SearchById(_uss.GetUser().Id);

				myuser.Senha = pw.Senha;

				await user.Update(myuser);

				TempData["MSGS"] = "Senha alterada com sucesso";

				return View(pw);
			}

			return View(pw);
		}


		/// <summary>
		/// pagina de alteracao e consulta de CEP
		/// </summary>
		/// <returns>redireciona para a pagina de consulta de cep</returns>
		[HttpGet("perfil/cep")]
		[RoleSecurityRoute(adm = IsAdmin)]
		public IActionResult CEP() => View();



		/// <summary>
		/// acao de alterar cep do usuario
		/// </summary>
		/// <param name="newcep">novo cep</param>
		/// <returns>retorna para a pagina, atualizando o endereco de cep buscado</returns>
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ALTCEP(string newcep)
		{

			if (Validations.DefaultSingleStringValidation(newcep, 20).Equals(true))
			{
				var myuser = await user.SearchById(_uss.GetUser().Id);

				myuser.CEP = newcep;

				await user.Update(myuser);

				_uss.Logon(new UserInfoViewModel() 
				{ 
					Id = myuser.IdUsuario,
					Email = myuser.Email,
					CEP = myuser.CEP,
					Nome = myuser.Nome,
					CanalId = myuser.CanalId
				});

				TempData["MSGS"] = "CEP alterado com sucesso!";

				return RedirectToAction(nameof(CEP));
			}

			TempData["MSGE"] = "Ocorreu um erro ao atualizar o CEP, tente novamente mais tarde.. ";

			return RedirectToAction(nameof(CEP));
		}





		/// <summary>
		/// Pagina com o nome do usuario
		/// </summary>
		/// <returns>retorna uma pagina com o nome do usuario</returns>
		[HttpGet("perfil/nome")]
		[RoleSecurityRoute(adm = IsAdmin)]
		public IActionResult NOME() => View();




		/// <summary>
		/// acao de alterar nome do usuario
		/// </summary>
		/// <param name="nome">nome do usuario</param>
		/// <returns>atualiza a pagina com o nome atualizado</returns>
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ALTNOME(string nome)
		{
			if (Validations.DefaultSingleStringValidation(nome, 30).Equals(true))
			{
				var myuser = await user.SearchById(_uss.GetUser().Id);

				myuser.Nome = nome;

				await user.Update(myuser);

				_uss.Logon(new UserInfoViewModel()
				{
					Id = myuser.IdUsuario,
					Email = myuser.Email,
					CEP = myuser.CEP,
					Nome = myuser.Nome,
					CanalId = myuser.CanalId
				});

				TempData["MSGS"] = "NOME alterado com sucesso!";

				return RedirectToAction(nameof(NOME));
			}

			TempData["MSGE"] = "Ocorreu um erro ao atualizar o NOME, tente novamente mais tarde.. ";

			return View(nameof(NOME));
		}




		/// <summary>
		/// pagina com a lista de transacoes do usuario
		/// </summary>
		/// <returns>redireciona para a pagina de transacoes do usuario</returns>
		[HttpGet("perfil/transacoes")]
		[RoleSecurityRoute(adm = IsAdmin)]
		public async Task<IActionResult> TRANSACOES() => View(await sl.GetUserHistory(_uss.GetUser().Id));


		/// <summary>
		/// pagina da transacao pelo id
		/// </summary>
		/// <param name="codigo">codigo buscado da transacao</param>
		/// <returns>retorna a transacao</returns>
		[HttpGet("perfil/transacoes/{codigo}")]
		[RouteRefererSecurity]
		[RoleSecurityRoute(adm = IsAdmin)]
		public async Task<IActionResult> TRANSACAO([FromRoute] string codigo) => View(await sl.GetHistory(codigo));


		/// <summary>
		/// pagina de interacao entre a loja e o cliente
		/// </summary>
		/// <returns>redireciona para a pagina de chat entre loja (administrador) e cliente</returns>
		[HttpGet("perfil/chat")]
		[RouteRefererSecurity]
		[RoleSecurityRoute(adm = IsAdmin)]
		public IActionResult CHAT() => View();



		/// <summary>
		/// Faz o logout do usuário no sistema
		/// </summary>
		/// <returns></returns>
		public IActionResult Logout()
		{
			_uss.Logout();

			Task.Delay(300);

			return Ok();
		}
		
	}
}
