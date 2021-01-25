namespace BankBills
{
  partial class BillsForm
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
      this.Bills_dataGridView = new System.Windows.Forms.DataGridView();
      this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UserNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AccountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.OperationDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AmountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Id_label = new System.Windows.Forms.Label();
      this.Id_textBox = new System.Windows.Forms.TextBox();
      this.UserName_textBox = new System.Windows.Forms.TextBox();
      this.UserName_label = new System.Windows.Forms.Label();
      this.Account_textBox = new System.Windows.Forms.TextBox();
      this.Account_label = new System.Windows.Forms.Label();
      this.OperationDate_label = new System.Windows.Forms.Label();
      this.Description_textBox = new System.Windows.Forms.TextBox();
      this.Description_label = new System.Windows.Forms.Label();
      this.Amount_textBox = new System.Windows.Forms.TextBox();
      this.Amount_label = new System.Windows.Forms.Label();
      this.OperationDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.Save_button = new System.Windows.Forms.Button();
      this.Delete_button = new System.Windows.Forms.Button();
      this.Add_button = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Bills_dataGridView)).BeginInit();
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
      this.menuStrip1.Size = new System.Drawing.Size(806, 24);
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
      this.Table_select_combo.Location = new System.Drawing.Point(675, 112);
      this.Table_select_combo.Name = "Table_select_combo";
      this.Table_select_combo.Size = new System.Drawing.Size(111, 21);
      this.Table_select_combo.TabIndex = 3;
      // 
      // Bills_dataGridView
      // 
      this.Bills_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Bills_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserNameCol,
            this.AccountCol,
            this.OperationDateCol,
            this.DescriptionCol,
            this.AmountCol});
      this.Bills_dataGridView.Location = new System.Drawing.Point(12, 137);
      this.Bills_dataGridView.Name = "Bills_dataGridView";
      this.Bills_dataGridView.Size = new System.Drawing.Size(774, 365);
      this.Bills_dataGridView.TabIndex = 5;
      this.Bills_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordSelect);
      // 
      // ID
      // 
      this.ID.HeaderText = "ID операции";
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      this.ID.Width = 60;
      // 
      // UserNameCol
      // 
      this.UserNameCol.HeaderText = "ФИО";
      this.UserNameCol.Name = "UserNameCol";
      this.UserNameCol.ReadOnly = true;
      this.UserNameCol.Width = 150;
      // 
      // AccountCol
      // 
      this.AccountCol.HeaderText = "Корреспондетский счет";
      this.AccountCol.Name = "AccountCol";
      this.AccountCol.ReadOnly = true;
      this.AccountCol.Width = 150;
      // 
      // OperationDateCol
      // 
      this.OperationDateCol.HeaderText = "Дата операции";
      this.OperationDateCol.Name = "OperationDateCol";
      this.OperationDateCol.ReadOnly = true;
      // 
      // DescriptionCol
      // 
      this.DescriptionCol.HeaderText = "Описание операции";
      this.DescriptionCol.Name = "DescriptionCol";
      this.DescriptionCol.ReadOnly = true;
      this.DescriptionCol.Width = 150;
      // 
      // AmountCol
      // 
      this.AmountCol.HeaderText = "Сумма";
      this.AmountCol.Name = "AmountCol";
      this.AmountCol.ReadOnly = true;
      this.AmountCol.Width = 120;
      // 
      // Id_label
      // 
      this.Id_label.AutoSize = true;
      this.Id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Id_label.Location = new System.Drawing.Point(13, 33);
      this.Id_label.Name = "Id_label";
      this.Id_label.Size = new System.Drawing.Size(99, 16);
      this.Id_label.TabIndex = 6;
      this.Id_label.Text = "ID операции";
      // 
      // Id_textBox
      // 
      this.Id_textBox.Enabled = false;
      this.Id_textBox.Location = new System.Drawing.Point(13, 51);
      this.Id_textBox.Name = "Id_textBox";
      this.Id_textBox.Size = new System.Drawing.Size(106, 20);
      this.Id_textBox.TabIndex = 7;
      this.Id_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInput);
      // 
      // UserName_textBox
      // 
      this.UserName_textBox.Location = new System.Drawing.Point(13, 93);
      this.UserName_textBox.Name = "UserName_textBox";
      this.UserName_textBox.Size = new System.Drawing.Size(203, 20);
      this.UserName_textBox.TabIndex = 9;
      this.UserName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringInput);
      // 
      // UserName_label
      // 
      this.UserName_label.AutoSize = true;
      this.UserName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.UserName_label.Location = new System.Drawing.Point(13, 74);
      this.UserName_label.Name = "UserName_label";
      this.UserName_label.Size = new System.Drawing.Size(42, 16);
      this.UserName_label.TabIndex = 8;
      this.UserName_label.Text = "ФИО";
      // 
      // Account_textBox
      // 
      this.Account_textBox.Location = new System.Drawing.Point(234, 92);
      this.Account_textBox.Name = "Account_textBox";
      this.Account_textBox.Size = new System.Drawing.Size(203, 20);
      this.Account_textBox.TabIndex = 11;
      this.Account_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInput);
      // 
      // Account_label
      // 
      this.Account_label.AutoSize = true;
      this.Account_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Account_label.Location = new System.Drawing.Point(234, 73);
      this.Account_label.Name = "Account_label";
      this.Account_label.Size = new System.Drawing.Size(186, 16);
      this.Account_label.TabIndex = 10;
      this.Account_label.Text = "Корреспондетский счет";
      // 
      // OperationDate_label
      // 
      this.OperationDate_label.AutoSize = true;
      this.OperationDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.OperationDate_label.Location = new System.Drawing.Point(234, 33);
      this.OperationDate_label.Name = "OperationDate_label";
      this.OperationDate_label.Size = new System.Drawing.Size(120, 16);
      this.OperationDate_label.TabIndex = 12;
      this.OperationDate_label.Text = "Дата операции";
      // 
      // Description_textBox
      // 
      this.Description_textBox.Location = new System.Drawing.Point(446, 51);
      this.Description_textBox.Name = "Description_textBox";
      this.Description_textBox.Size = new System.Drawing.Size(203, 20);
      this.Description_textBox.TabIndex = 15;
      this.Description_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StringInput);
      // 
      // Description_label
      // 
      this.Description_label.AutoSize = true;
      this.Description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Description_label.Location = new System.Drawing.Point(446, 32);
      this.Description_label.Name = "Description_label";
      this.Description_label.Size = new System.Drawing.Size(157, 16);
      this.Description_label.TabIndex = 14;
      this.Description_label.Text = "Описание операции";
      // 
      // Amount_textBox
      // 
      this.Amount_textBox.Location = new System.Drawing.Point(446, 93);
      this.Amount_textBox.Name = "Amount_textBox";
      this.Amount_textBox.Size = new System.Drawing.Size(203, 20);
      this.Amount_textBox.TabIndex = 17;
      this.Amount_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInput);
      // 
      // Amount_label
      // 
      this.Amount_label.AutoSize = true;
      this.Amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Amount_label.Location = new System.Drawing.Point(446, 74);
      this.Amount_label.Name = "Amount_label";
      this.Amount_label.Size = new System.Drawing.Size(56, 16);
      this.Amount_label.TabIndex = 16;
      this.Amount_label.Text = "Сумма";
      // 
      // OperationDate_dateTimePicker
      // 
      this.OperationDate_dateTimePicker.Location = new System.Drawing.Point(234, 51);
      this.OperationDate_dateTimePicker.MaxDate = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
      this.OperationDate_dateTimePicker.Name = "OperationDate_dateTimePicker";
      this.OperationDate_dateTimePicker.Size = new System.Drawing.Size(150, 20);
      this.OperationDate_dateTimePicker.TabIndex = 18;
      this.OperationDate_dateTimePicker.Value = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
      // 
      // Save_button
      // 
      this.Save_button.Location = new System.Drawing.Point(692, 25);
      this.Save_button.Name = "Save_button";
      this.Save_button.Size = new System.Drawing.Size(74, 23);
      this.Save_button.TabIndex = 19;
      this.Save_button.Text = "Сохранить";
      this.Save_button.UseVisualStyleBackColor = true;
      // 
      // Delete_button
      // 
      this.Delete_button.Location = new System.Drawing.Point(692, 54);
      this.Delete_button.Name = "Delete_button";
      this.Delete_button.Size = new System.Drawing.Size(74, 23);
      this.Delete_button.TabIndex = 20;
      this.Delete_button.Text = "Удалить";
      this.Delete_button.UseVisualStyleBackColor = true;
      // 
      // Add_button
      // 
      this.Add_button.Location = new System.Drawing.Point(692, 83);
      this.Add_button.Name = "Add_button";
      this.Add_button.Size = new System.Drawing.Size(74, 23);
      this.Add_button.TabIndex = 27;
      this.Add_button.Text = "Добавить";
      this.Add_button.UseVisualStyleBackColor = true;
      // 
      // BillsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(806, 513);
      this.Controls.Add(this.Add_button);
      this.Controls.Add(this.Delete_button);
      this.Controls.Add(this.Save_button);
      this.Controls.Add(this.OperationDate_dateTimePicker);
      this.Controls.Add(this.Amount_textBox);
      this.Controls.Add(this.Amount_label);
      this.Controls.Add(this.Description_textBox);
      this.Controls.Add(this.Description_label);
      this.Controls.Add(this.OperationDate_label);
      this.Controls.Add(this.Account_textBox);
      this.Controls.Add(this.Account_label);
      this.Controls.Add(this.UserName_textBox);
      this.Controls.Add(this.UserName_label);
      this.Controls.Add(this.Id_textBox);
      this.Controls.Add(this.Id_label);
      this.Controls.Add(this.Bills_dataGridView);
      this.Controls.Add(this.Table_select_combo);
      this.Controls.Add(this.menuStrip1);
      this.MaximizeBox = false;
      this.Name = "BillsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Банковские счета";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Bills_dataGridView)).EndInit();
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
    private System.Windows.Forms.DataGridView Bills_dataGridView;
    private System.Windows.Forms.Label Id_label;
    private System.Windows.Forms.TextBox Id_textBox;
    private System.Windows.Forms.TextBox UserName_textBox;
    private System.Windows.Forms.Label UserName_label;
    private System.Windows.Forms.TextBox Account_textBox;
    private System.Windows.Forms.Label Account_label;
    private System.Windows.Forms.Label OperationDate_label;
    private System.Windows.Forms.TextBox Description_textBox;
    private System.Windows.Forms.Label Description_label;
    private System.Windows.Forms.TextBox Amount_textBox;
    private System.Windows.Forms.Label Amount_label;
    private System.Windows.Forms.DateTimePicker OperationDate_dateTimePicker;
    private System.Windows.Forms.Button Save_button;
    private System.Windows.Forms.Button Delete_button;
    private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    private System.Windows.Forms.DataGridViewTextBoxColumn UserNameCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn AccountCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn OperationDateCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn AmountCol;
    private System.Windows.Forms.Button Add_button;
  }
}