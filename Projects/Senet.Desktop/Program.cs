using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Senete.Desktop
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      var host = Host.CreateDefaultBuilder()
        .ConfigureServices((context, services) =>
        {
          ConfigureServices(context.Configuration, services);
        })
        .Build();

      var services = host.Services;
      var mainForm = services.GetRequiredService<MainForm>();

      Application.Run(mainForm);
    }

    private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
    {
      services
        .AddSingleton<MainForm>();
    }
  }
}
