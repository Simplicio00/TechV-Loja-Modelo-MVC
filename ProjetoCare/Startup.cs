using System;
using System.Globalization;
using Classes.Canal;
using Data.Contexts;
using Data.Resources.Interfaces;
using Data.Resources.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoCare.Utils.ArchiveUpload;
using ProjetoCare.Utils.Autentication;
using ProjetoCare.Utils.Cards;
using ProjetoCare.Utils.Cookie;
using ProjetoCare.Utils.Payment;
using ProjetoCare.Utils.ReceiverSgnR;
using ProjetoCare.Utils.Session;

namespace ProjetoCare
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddServerSideBlazor();

			services
				.AddAuthentication()
				.AddGoogle(
					op =>
					{
						op.ClientId = Configuration.GetConnectionString("AppGoogleClientId");
						op.ClientSecret = Configuration.GetConnectionString("AppGoogleClientSecret");
					}
				);

			services.AddControllersWithViews(op =>
			{
				op.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(resp => "O campo não pode ser nulo!");
				op.ModelBindingMessageProvider.SetValueIsInvalidAccessor(rep => "O campo está inválido");
				op.ModelBindingMessageProvider.SetMissingKeyOrValueAccessor(() => "O campo {0} não foi preenchido!");
			})
			.SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

			services.AddDbContext<DBContext>(a => a.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection"), a => a.MigrationsAssembly("ProjetoCare")));

			services.AddScoped<ShoppingCart>();
			services.AddScoped<Cookie>();
			services.AddScoped<Session>();
			services.AddScoped<UserSession>();
			services.AddScoped<BoletoPDFGenerator>();


			services.AddScoped<UploadFile>();
			services.AddScoped<Autentication>();
			services.AddHttpContextAccessor();
			services.AddSession();
			services.AddSignalR();

			
			services.AddScoped<ISystemlog, SystemLogReport>();
			services.AddScoped<ICategoria, CategoriaRepository>();
			services.AddScoped<IProduto, ProdutoRepository>();
			services.AddScoped<IEstoque, EstoqueRepository>();
			services.AddScoped<I_IMG, ImagemRepository>();
			services.AddScoped<IUsuario, UsuarioRepository>();
			services.AddScoped<ICanal, CanalRepository>();
		}


		[Obsolete]
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			//Adicionando suporte para o padrão PT-BR
			var supportedCultures = new[] { new CultureInfo("pt-BR") };

			app.UseRequestLocalization(new RequestLocalizationOptions
			{
				DefaultRequestCulture = new RequestCulture(culture: "pt-BR", uiCulture: "pt-BR"),
				SupportedCultures = supportedCultures,
				SupportedUICultures = supportedCultures
			});


			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseSession();

			app.UseCookiePolicy();

			app.UseRouting();

			app.UseAuthorization();

			app.UseSignalR(s =>
			{
				s.MapHub<Chat>("/chat");
			});

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "areas",
					pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
					);
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
