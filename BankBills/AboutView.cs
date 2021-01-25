using BankBills.Presenter;
using System.Windows.Forms;

namespace BankBills
{
  public partial class AboutView : Form, IAboutView
  {
    public AboutView()
    {
      InitializeComponent();
    }
    public new void Show()
    {
      ShowDialog();
    }
  }
}
