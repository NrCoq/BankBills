using BankBills.Presenter;
using System;
using System.Windows.Forms;

namespace BankBills
{
  public partial class BanksForm : Form, IBanksView
  {
    private readonly ApplicationContext _context;

    public string ComboItem { get => Table_select_combo.SelectedItem.ToString(); set => Table_select_combo.Items.Add(value); }

    public string ComboSelectedItem { get => Table_select_combo.SelectedItem == null ? "" : Table_select_combo.SelectedItem.ToString(); set => Table_select_combo.SelectedItem = value; }

    public string Account { get => Account_textBox.Text; set => Account_textBox.Text = value; }

    public string BankName { get => BankName_textBox.Text; set => BankName_textBox.Text = value; }

    public BanksForm(ApplicationContext context)
    {
      _context = context;
      InitializeComponent();

      Table_select_combo.SelectedIndexChanged += (sender, args) => Action(TableSelect);
      Save_button.Click += (sender, args) => Action(Save);
      Delete_button.Click += (sender, args) => Action(Delete);
      Exit_menu_item.Click += (sender, args) => Action(Exit);
      About_menu_item.Click += (sender, args) => Action(About);
      Save_menu_item.Click += (sender, args) => Action(Export);
    }

    public new void Show()
    {
      _context.MainForm = this;
      base.Show();
    }

    public event Action Export;

    public event Action TableSelect;

    public event Action Save;

    public event Action Delete;

    public event Action About;

    public event Action Exit;

    private void Action(Action action)
    {
      try
      {
        action?.Invoke();
      }
      catch (Exception e)
      {
        ShowError(e.Message);
      }
    }

    public void ShowError(string errorMessage)
    {
      MessageBox.Show(errorMessage, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void ShowWarning(string warningMessage)
    {
      MessageBox.Show(warningMessage, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public void ShowSuccess(string successMessage)
    {
      MessageBox.Show(successMessage, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void IntInput(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private void StringInput(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private void RecordSelect(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        if (Banks_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        {
          BankName = Banks_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
          Account = Banks_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
      }
      catch (Exception)
      {
        MessageBox.Show("Выберите ячейку таблицы!",
        "Ошибка",
         MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public void TableFill(string[,] array)
    {
      if (array.Length == 0)
      {
        return;
      }
      Banks_dataGridView.RowCount = array.GetUpperBound(0) + 1;
      for (int i = 0; i < (array.GetUpperBound(0) + 1); i++)
      {
        for (int j = 0; j < (array.GetUpperBound(1) + 1); j++)
        {
          Banks_dataGridView.Rows[i].Cells[j].Value = array[i, j];
        }
      }
    }

  }
}
