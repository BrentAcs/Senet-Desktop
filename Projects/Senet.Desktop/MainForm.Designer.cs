
namespace Senete.Desktop
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.paddleRoller1 = new Senet.Desktop.Controls.PaddleRoller();
      this.SuspendLayout();
      // 
      // paddleRoller1
      // 
      this.paddleRoller1.Location = new System.Drawing.Point(12, 12);
      this.paddleRoller1.MinimumSize = new System.Drawing.Size(311, 164);
      this.paddleRoller1.Name = "paddleRoller1";
      this.paddleRoller1.Size = new System.Drawing.Size(311, 164);
      this.paddleRoller1.TabIndex = 1;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(766, 429);
      this.Controls.Add(this.paddleRoller1);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private Senet.Desktop.Controls.PaddleRoller paddleRoller1;
  }
}

