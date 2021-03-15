using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Senet.Desktop;

namespace Senete.Desktop
{
  public partial class MainForm : Form
  {
    private readonly IConfiguration _config;
    private readonly IServiceProvider _serviceProvider;

    public MainForm(
      IConfiguration config,
      IServiceProvider serviceProvider)
    {
      _config = config;
      _serviceProvider = serviceProvider;
      InitializeComponent();

      foreach (ISenetControl control in Controls.OfType<ISenetControl>())
      {
        control.InitSenetControl(serviceProvider);
      }
    }
  }
}
