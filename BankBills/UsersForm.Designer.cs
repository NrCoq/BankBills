namespace BankBills
{

  partial class UsersForm
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
      this.Users_dataGridView = new System.Windows.Forms.DataGridView();
      this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Users = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Save_button = new System.Windows.Forms.Button();
      this.Name_textBox = new System.Windows.Forms.TextBox();
      this.Name_label = new System.Windows.Forms.Label();
      this.Id_textBox = new System.Windows.Forms.TextBox();
      this.Id_label = new System.Windows.Forms.Label();
      this.Delete_button = new System.Windows.Forms.Button();
      this.Add_button = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).BeginInit();
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
      this.menuStrip1.Size = new System.Drawing.Size(501, 24);
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
      this.Table_select_combo.Location = new System.Drawing.Point(328, 119);
      this.Table_select_combo.Name = "Table_select_combo";
      this.Table_select_combo.Size = new System.Drawing.Size(111, 21);
      this.Table_select_combo.TabIndex = 3;
      // 
      // Users_dataGridView
      // 
      this.Users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Users_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Users});
      this.Users_dataGridView.Location = new System.Drawing.Point(12, 146);
      this.Users_dataGridView.Name = "Users_dataGridView";
      this.Users_dataGridView.Size = new System.Drawing.Size(473, 437);
      this.Users_dataGridView.TabIndex = 4;
      this.Users_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordSelect);
      // 
      // ID
      // 
      this.ID.HeaderText = "ID";
      this.ID.Name = "ID";
      this.ID.ReadOnly = true;
      // 
      // Users
      // 
      this.Users.HeaderText = "ФИО";
      this.Users.Name = "Users";
      this.Users.ReadOnly = true;
      this.Users.Width = 330;
      // 
      // Save_button
      // 
      this.Save_button.Location = new System.Drawing.Point(346, 32);
      this.Save_button.Name = "Save_button";
      this.Save_button.Size = new System.Drawing.Size(77, 23);
      this.Save_button.TabIndex = 24;
      this.Save_button.Text = "Сохранить";
      this.Save_button.UseVisualStyleBackColor = true;
      // 
      // Name_textBox
      // 
      this.Name_textBox.Location = new System.Drawing.Point(65, 93);
      this.Name_textBox.Name = "Name_textBox";
      this.Name_textBox.Size = new System.Drawing.Size(233, 20);
      this.Name_textBox.TabIndex = 23;
      // 
      // Name_label
      // 
      this.Name_label.AutoSize = true;
      this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Name_label.Location = new System.Drawing.Point(65, 75);
      this.Name_label.Name = "Name_label";
      this.Name_label.Size = new System.Drawing.Size(42, 16);
      this.Name_label.TabIndex = 22;
      this.Name_label.Text = "ФИО";
      // 
      // Id_textBox
      // 
      this.Id_textBox.Enabled = false;
      this.Id_textBox.Location = new System.Drawing.Point(65, 48);
      this.Id_textBox.Name = "Id_textBox";
      this.Id_textBox.Size = new System.Drawing.Size(60, 20);
      this.Id_textBox.TabIndex = 21;
      this.Id_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInput);
      // 
      // Id_label
      // 
      this.Id_label.AutoSize = true;
      this.Id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Id_label.Location = new System.Drawing.Point(65, 30);
      this.Id_label.Name = "Id_label";
      this.Id_label.Size = new System.Drawing.Size(23, 16);
      this.Id_label.TabIndex = 20;
      this.Id_label.Text = "ID";
      // 
      // Delete_button
      // 
      this.Delete_button.Location = new System.Drawing.Point(346, 61);
      this.Delete_button.Name = "Delete_button";
      this.Delete_button.Size = new System.Drawing.Size(77, 23);
      this.Delete_button.TabIndex = 25;
      this.Delete_button.Text = "Удалить";
      this.Delete_button.UseVisualStyleBackColor = true;
      // 
      // Add_button
      // 
      this.Add_button.Location = new System.Drawing.Point(346, 90);
      this.Add_button.Name = "Add_button";
      this.Add_button.Size = new System.Drawing.Size(77, 23);
      this.Add_button.TabIndex = 26;
      this.Add_button.Text = "Добавить";
      this.Add_button.UseVisualStyleBackColor = true;
      // 
      // UsersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(501, 595);
      this.Controls.Add(this.Add_button);
      this.Controls.Add(this.Delete_button);
      this.Controls.Add(this.Save_button);
      this.Controls.Add(this.Name_textBox);
      this.Controls.Add(this.Name_label);
      this.Controls.Add(this.Id_textBox);
      this.Controls.Add(this.Id_label);
      this.Controls.Add(this.Users_dataGridView);
      this.Controls.Add(this.Table_select_combo);
      this.Controls.Add(this.menuStrip1);
      this.Name = "UsersForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Пользователи";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Users_dataGridView)).EndInit();
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
    private System.Windows.Forms.DataGridView Users_dataGridView;
    private System.Windows.Forms.Button Save_button;
    private System.Windows.Forms.TextBox Name_textBox;
    private System.Windows.Forms.Label Name_label;
    private System.Windows.Forms.TextBox Id_textBox;
    private System.Windows.Forms.Label Id_label;
    private System.Windows.Forms.Button Delete_button;
    private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    private System.Windows.Forms.DataGridViewTextBoxColumn Users;
    private System.Windows.Forms.Button Add_button;
  }
}