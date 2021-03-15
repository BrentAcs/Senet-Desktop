using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Senet.Desktop.Controls
{
  public partial class PaddleRoller : SenetControl
  {
    private enum PaddleRoll
    {
      Up = 0,
      Down = 1,
    }

    private IRng _rng;
    private PictureBox[] _paddlePictureBoxes;

    public PaddleRoller()
    {
      InitializeComponent();

      _paddlePictureBoxes = new PictureBox[]
      {
        paddle1PictureBox,
        paddle2PictureBox,
        paddle3PictureBox,
        paddle4PictureBox,
      };
    }

    public override void InitSenetControl(IServiceProvider serviceProvider)
    {
      base.InitSenetControl(serviceProvider);

      _rng = serviceProvider.GetRequiredService<IRng>();
    }

    private void rollButton_Click(object sender, EventArgs e)
    {
      int rollResult = 0;

      for (int i = 0; i < 10; i++)
      {
        rollResult = 0;
        foreach (PictureBox pictureBox in _paddlePictureBoxes)
        {
          PaddleRoll roll = (PaddleRoll)_rng.Next(0, 2);

          if (roll == PaddleRoll.Up)
          {
            rollResult++;
            pictureBox.Image = Properties.Resources.paddle_up;
          }
          else
          {
            pictureBox.Image = Properties.Resources.paddle_up;
          }

          pictureBox.Update();
        }

        if (rollResult == 0)
        {
          rollResult = 5;
        }

        Thread.Sleep(200);
      }

      label1.Text = $"Roll: {rollResult}";
    }
  }
}
