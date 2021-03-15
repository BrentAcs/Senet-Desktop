
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
      this.paddle5PictureBox = new System.Windows.Forms.PictureBox();
      this.paddle4PictureBox = new System.Windows.Forms.PictureBox();
      this.paddle3PictureBox = new System.Windows.Forms.PictureBox();
      this.paddle2PictureBox = new System.Windows.Forms.PictureBox();
      this.paddle1PictureBox = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.paddlePanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.paddle5PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddle4PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddle3PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddle2PictureBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddle1PictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // paddlePanel
      // 
      this.paddlePanel.Controls.Add(this.paddle5PictureBox);
      this.paddlePanel.Controls.Add(this.paddle4PictureBox);
      this.paddlePanel.Controls.Add(this.paddle3PictureBox);
      this.paddlePanel.Controls.Add(this.paddle2PictureBox);
      this.paddlePanel.Controls.Add(this.paddle1PictureBox);
      this.paddlePanel.Location = new System.Drawing.Point(5, 5);
      this.paddlePanel.Name = "paddlePanel";
      this.paddlePanel.Size = new System.Drawing.Size(170, 154);
      this.paddlePanel.TabIndex = 0;
      // 
      // paddle5PictureBox
      // 
      this.paddle5PictureBox.Image = global::Senet.Desktop.Properties.Resources.paddle_down;
      this.paddle5PictureBox.Location = new System.Drawing.Point(141, 5);
      this.paddle5PictureBox.Name = "paddle5PictureBox";
      this.paddle5PictureBox.Size = new System.Drawing.Size(24, 144);
      this.paddle5PictureBox.TabIndex = 4;
      this.paddle5PictureBox.TabStop = false;
      // 
      // paddle4PictureBox
      // 
      this.paddle4PictureBox.Image = global::Senet.Desktop.Properties.Resources.paddle_down;
      this.paddle4PictureBox.Location = new System.Drawing.Point(107, 5);
      this.paddle4PictureBox.Name = "paddle4PictureBox";
      this.paddle4PictureBox.Size = new System.Drawing.Size(24, 144);
      this.paddle4PictureBox.TabIndex = 3;
      this.paddle4PictureBox.TabStop = false;
      // 
      // paddle3PictureBox
      // 
      this.paddle3PictureBox.Image = global::Senet.Desktop.Properties.Resources.paddle_down;
      this.paddle3PictureBox.Location = new System.Drawing.Point(73, 5);
      this.paddle3PictureBox.Name = "paddle3PictureBox";
      this.paddle3PictureBox.Size = new System.Drawing.Size(24, 144);
      this.paddle3PictureBox.TabIndex = 2;
      this.paddle3PictureBox.TabStop = false;
      // 
      // paddle2PictureBox
      // 
      this.paddle2PictureBox.Image = global::Senet.Desktop.Properties.Resources.paddle_down;
      this.paddle2PictureBox.Location = new System.Drawing.Point(39, 5);
      this.paddle2PictureBox.Name = "paddle2PictureBox";
      this.paddle2PictureBox.Size = new System.Drawing.Size(24, 144);
      this.paddle2PictureBox.TabIndex = 1;
      this.paddle2PictureBox.TabStop = false;
      // 
      // paddle1PictureBox
      // 
      this.paddle1PictureBox.Image = global::Senet.Desktop.Properties.Resources.paddle_down;
      this.paddle1PictureBox.Location = new System.Drawing.Point(5, 5);
      this.paddle1PictureBox.Name = "paddle1PictureBox";
      this.paddle1PictureBox.Size = new System.Drawing.Size(24, 144);
      this.paddle1PictureBox.TabIndex = 0;
      this.paddle1PictureBox.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(181, 10);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // PaddleRoller
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.button1);
      this.Controls.Add(this.paddlePanel);
      this.MinimumSize = new System.Drawing.Size(311, 164);
      this.Name = "PaddleRoller";
      this.Size = new System.Drawing.Size(311, 164);
      this.paddlePanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.paddle5PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddle4PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddle3PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddle2PictureBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paddle1PictureBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel paddlePanel;
    private System.Windows.Forms.PictureBox paddle1PictureBox;
    private System.Windows.Forms.PictureBox paddle5PictureBox;
    private System.Windows.Forms.PictureBox paddle4PictureBox;
    private System.Windows.Forms.PictureBox paddle3PictureBox;
    private System.Windows.Forms.PictureBox paddle2PictureBox;
    private System.Windows.Forms.Button button1;
  }
}
