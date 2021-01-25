namespace BankBills
{
  partial class BanksForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.Save_menu_item = new System.Windows.Forms.ToolStripMenuItem();
      this.rToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
      this.Exit_menu_item = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.About_menu_item = new System.Windows.Forms.ToolStripMenuItem();
      this.Table_select_combo = new System.Windows.Forms.ComboBox();
      this.Banks_dataGridView = new System.Windows.Forms.DataGridView();
      this.NameOfBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Save_button = new System.Windows.Forms.Button();
      this.BankName_textBox = new System.Windows.Forms.TextBox();
      this.BankName_label = new System.Windows.Forms.Label();
      this.Account_textBox = new System.Windows.Forms.TextBox();
      this.Account_label = new System.Windows.Forms.Label();
      this.Delete_button = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Banks_dataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(580, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save_menu_item,
            this.rToolStripMenuItem,
            this.Exit_menu_item});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
      this.fileToolStripMenuItem.Text = "Файл";
      // 
      // Save_menu_item
      // 
      this.Save_menu_item.Name = "Save_menu_item";
      this.Save_menu_item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.Save_menu_item.Size = new System.Drawing.Size(170, 22);
      this.Save_menu_item.Text = "Сохранить";
      // 
      // rToolStripMenuItem
      // 
      this.rToolStripMenuItem.Name = "rToolStripMenuItem";
      this.rToolStripMenuItem.Size = new System.Drawing.Size(167, 6);
      // 
      // Exit_menu_item
      // 
      this.Exit_menu_item.Name = "Exit_menu_item";
      this.Exit_menu_item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
      this.Exit_menu_item.Size = new System.Drawing.Size(170, 22);
      this.Exit_menu_item.Text = "Закрыть";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_menu_item});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
      this.helpToolStripMenuItem.Text = "Помощь";
      // 
      // About_menu_item
      // 
      this.About_menu_item.Name = "About_menu_item";
      this.About_menu_item.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.About_menu_item.Size = new System.Drawing.Size(159, 22);
      this.About_menu_item.Text = "Справка";
      // 
      // Table_select_combo
      // 
      this.Table_select_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.Table_select_combo.FormattingEnabled = true;
      this.Table_select_combo.Location = new System.Drawing.Point(333, 91);
      this.Table_select_combo.Name = "Table_select_combo";
      this.Table_select_combo.Size = new System.Drawing.Size(111, 21);
      this.Table_select_combo.TabIndex = 3;
      // 
      // Banks_dataGridView
      // 
      this.Banks_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Banks_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfBank,
            this.BankAccount});
      this.Banks_dataGridView.Location = new System.Drawing.Point(12, 119);
      this.Banks_dataGridView.Name = "Banks_dataGridView";
      this.Banks_dataGridView.Size = new System.Drawing.Size(544, 370);
      this.Banks_dataGridView.TabIndex = 5;
      this.Banks_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordSelect);
      // 
      // NameOfBank
      // 
      this.NameOfBank.HeaderText = "Название";
      this.NameOfBank.Name = "NameOfBank";
      this.NameOfBank.ReadOnly = true;
      this.NameOfBank.Width = 250;
      // 
      // BankAccount
      // 
      this.BankAccount.HeaderText = "Корреспондентский счет";
      this.BankAccount.Name = "BankAccount";
      this.BankAccount.ReadOnly = true;
      this.BankAccount.Width = 250;
      // 
      // Save_button
      // 
      this.Save_button.Location = new System.Drawing.Point(346, 33);
      this.Save_button.Name = "Save_button";
      this.Save_button.Size = new System.Drawing.Size(83, 23);
      this.Save_button.TabIndex = 29;
      this.Save_button.Text = "Сохранить";
      this.Save_button.UseVisualStyleBackColor = true;
      // 
      // BankName_textBox
      // 
      this.BankName_textBox.Location = new System.Drawing.Point(95, 91);
      this.BankName_textBox.Name = "BankName_textBox";
      this.BankName_textBox.Size = new System.Drawing.Size(190, 20);
      this.BankName_textBox.TabIndex = 28;
      this.BankName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringInput);
      // 
      // BankName_label
      // 
      this.BankName_label.AutoSize = true;
      this.BankName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.BankName_label.Location = new System.Drawing.Point(95, 73);
      this.BankName_label.Name = "BankName_label";
      this.BankName_label.Size = new System.Drawing.Size(82, 16);
      this.BankName_label.TabIndex = 27;
      this.BankName_label.Text = "Название";
      // 
      // Account_textBox
      // 
      this.Account_textBox.Location = new System.Drawing.Point(95, 50);
      this.Account_textBox.Name = "Account_textBox";
      this.Account_textBox.Size = new System.Drawing.Size(190, 20);
      this.Account_textBox.TabIndex = 26;
      this.Account_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInput);
      // 
      // Account_label
      // 
      this.Account_label.AutoSize = true;
      this.Account_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Account_label.Location = new System.Drawing.Point(95, 32);
      this.Account_label.Name = "Account_label";
      this.Account_label.Size = new System.Drawing.Size(195, 16);
      this.Account_label.TabIndex = 25;
      this.Account_label.Text = "Корреспондентский счет";
      // 
      // Delete_button
      // 
      this.Delete_button.Location = new System.Drawing.Point(346, 62);
      this.Delete_button.Name = "Delete_button";
      this.Delete_button.Size = new System.Drawing.Size(83, 23);
      this.Delete_button.TabIndex = 30;
      this.Delete_button.Text = "Удалить";
      this.Delete_button.UseVisualStyleBackColor = true;
      // 
      // BanksForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(580, 501);
      this.Controls.Add(this.Delete_button);
      this.Controls.Add(this.Save_button);
      this.Controls.Add(this.BankName_textBox);
      this.Controls.Add(this.BankName_label);
      this.Controls.Add(this.Account_textBox);
      this.Controls.Add(this.Account_label);
      this.Controls.Add(this.Banks_dataGridView);
      this.Controls.Add(this.Table_select_combo);
      this.Controls.Add(this.menuStrip1);
      this.Name = "BanksForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Банки";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Banks_dataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem Save_menu_item;
    private System.Windows.Forms.ToolStripSeparator rToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem Exit_menu_item;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem About_menu_item;
    private System.Windows.Forms.ComboBox Table_select_combo;
    private System.Windows.Forms.DataGridView Banks_dataGridView;
    private System.Windows.Forms.Button Save_button;
    private System.Windows.Forms.TextBox BankName_textBox;
    private System.Windows.Forms.Label BankName_label;
    private System.Windows.Forms.TextBox Account_textBox;
    private System.Windows.Forms.Label Account_label;
    private System.Windows.Forms.Button Delete_button;
    private System.Windows.Forms.DataGridViewTextBoxColumn NameOfBank;
    private System.Windows.Forms.DataGridViewTextBoxColumn BankAccount;
  }
}