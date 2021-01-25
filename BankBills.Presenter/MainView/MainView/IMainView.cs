using System;

namespace BankBills.Presenter
{

  public interface IMainView : IView
  {
    string ComboItem { get; set; }

    string ComboSelectedItem { get; set; }

    event Action TableSelect;

    event Action About;

    event Action Exit;

    void ShowError(string errorMessage);

    void ShowWarning(string warningMessage);

    void ShowSuccess(string successMessage);
  }
}
