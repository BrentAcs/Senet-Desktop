using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Senet.Desktop.Controls
{
  public partial class PaddleRoller : UserControl, ISenetControl
  {
    private IRng _rng;

    public PaddleRoller()
    {
      InitializeComponent();
    }

    public void InitSenetControl(IServiceProvider serviceProvider)
    {
      _rng = serviceProvider.GetRequiredService<IRng>();
    }
  }
}
