namespace BankBills
{
  partial class AboutView
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
      this.Author = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // Author
      // 
      this.Author.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.Author.AutoSize = true;
      this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Author.Location = new System.Drawing.Point(12, 18);
      this.Author.Name = "Author";
      this.Author.Size = new System.Drawing.Size(409, 30);
      this.Author.TabIndex = 12;
      this.Author.Text = "Данная программа позволить вам редактировать банковские счета\r\nСделал Ушаков Олег" +
    " 485 гр.";
      this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // AboutView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(435, 66);
      this.Controls.Add(this.Author);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "О приложении";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label Author;
  }
}