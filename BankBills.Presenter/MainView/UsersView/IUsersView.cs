using System;

namespace BankBills.Presenter
{
  public interface IUsersView : IMainView
  {
    string Id { get; set; }

    string Name { get; set; }

    event Action Save;

    event Action Delete;

    event Action Add;

    event Action Export;

    void TableFill(string[,] array);
  }
}
