using System;
using System.Collections.Generic;
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
    public void InitSenetControl(IServiceProvider serviceProvider)
    {
      
    }
  } 
}
