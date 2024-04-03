using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReklamYuzum.Business.Abstract;
using ReklamYuzum.Business.Concrete;
using ReklamYuzum.DataAccess.Abstract;
using ReklamYuzum.DataAccess.Concrete;
using ReklamYuzum.UI;
using ReklamYuzum.UI.Views;

namespace ReklamYuzum.UI
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			var host = CreateHostBuilder().Build();
			ServiceProvider = host.Services;

			var frmRegister = ServiceProvider.GetRequiredService<frmRegister>();

			Application.Run(frmRegister);
		}
		public static IServiceProvider ServiceProvider { get; private set; }


		static IHostBuilder CreateHostBuilder()
		{
			return Host.CreateDefaultBuilder()
				.ConfigureServices((context, services) => {
					services.AddSingleton<IProfileService, ProfileManager>();
					services.AddSingleton<IProfileDal, EfProfileDal>();
					string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

					services.AddDbContext<ReklamYuzumContext>(options =>
						options.UseSqlServer(connectionString));

					services.AddSingleton<frmRegister>();
					services.AddSingleton<SignIn>();
				});
		}
	}
}