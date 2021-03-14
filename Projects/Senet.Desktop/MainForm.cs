using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

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
    }
  }
}
