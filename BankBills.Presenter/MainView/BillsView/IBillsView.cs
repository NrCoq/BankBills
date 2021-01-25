using System;

namespace BankBills.Presenter
{
  public interface IBillsView : IMainView
  {
    string Id { get; set; }

    string UserName { get; set; }

    string Account { get; set; }

    string OperationDate { get; set; }

    string Description { get; set; }

    string Amount { get; set; }

    event Action Save;

    event Action Delete;

    event Action Add;

    event Action Export;

    void TableFill(string[,] array);
  }
}
