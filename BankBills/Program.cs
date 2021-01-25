using BankBills.Presenter;
using System;
using System.Windows.Forms;

namespace BankBills
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      IApplicationController controller = new ApplicationController(new LightInjectAdapter())
          .RegisterView<IBillsView, BillsForm>()
          .RegisterView<IUsersView, UsersForm>()
          .RegisterView<IBanksView, BanksForm>()
          .RegisterView<IAboutView, AboutView>()
          .RegisterInstance(new ApplicationContext());
      Properties.Settings.Default.fisrtLaunch = true;
      Properties.Settings.Default.Save();
      controller.Run<BillsPresenter>();
    }
  }
}