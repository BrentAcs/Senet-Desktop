using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Senet.Desktop
{
  public interface ISenetControl
  {
    void InitSenetControl(IServiceProvider serviceProvider);
  }

  public class SenetControl : UserControl, ISenetControl
  {
    protected IServiceProvider ServiceProvider { get; private set; }

    public virtual void InitSenetControl(IServiceProvider serviceProvider)
    {
      ServiceProvider = serviceProvider;

      foreach (ISenetControl control in Controls.OfType<ISenetControl>())
      {
        control.InitSenetControl(serviceProvider);
      }
    }
  } 
}
