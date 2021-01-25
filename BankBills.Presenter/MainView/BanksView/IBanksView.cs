using System;

namespace BankBills.Presenter
{
  public interface IBanksView : IMainView
  {
    string BankName { get; set; }

    string Account { get; set; }

    event Action Save;

    event Action Delete;

    event Action Export;

    void TableFill(string[,] array);
  }
}
