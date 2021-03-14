
namespace Senet.Desktop.Controls
{
  partial class PaddleRoller
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.paddlePanel = new System.Windows.Forms.Panel();
      this.paddle1PictureBox = new System.Windows.Forms.PictureBox();
      this.paddlePanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.paddle1PictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // paddlePanel
      // 
      this.paddlePanel.Controls.Add(this.paddle1PictureBox);
      this.paddlePanel.Location = new System.Drawing.Point(40, 47);
      this.paddlePanel.Name = "paddlePanel";
      this.paddlePanel.Size = new System.Drawing.Size(170, 154);
      this.paddlePanel.TabIndex = 0;
      // 
      // paddle1PictureBox
      // 
      this.paddle1PictureBox.Location = new System.Drawing.Point(5, 5);
      this.paddle1PictureBox.Name = "paddle1PictureBox";
      this.paddle1PictureBox.Size = new System.Drawing.Size(24, 144);
      this.paddle1PictureBox.TabIndex = 0;
      this.paddle1PictureBox.TabStop = false;
      // 
      // PaddleRoller
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.paddlePanel);
      this.Name = "PaddleRoller";
      this.Size = new System.Drawing.Size(485, 322);
      this.paddlePanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.paddle1PictureBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel paddlePanel;
    private System.Windows.Forms.PictureBox paddle1PictureBox;
  }
}
