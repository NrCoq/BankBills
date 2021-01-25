using System;
using BankBills.Model;

namespace BankBills.Presenter
{
  public class MainPresenter : BasePresenter<IMainView>
  {
    private readonly IMainView _view;

    public MainPresenter(IApplicationController controller, IMainView view) : base(controller, view)
    {
      _view = view;
      foreach (Entities entity in Enum.GetValues(typeof(Entities)))
      {
        _view.ComboItem = entity.ToString();
      }

      Repository<Banks>.DataBaseChecking();

      _view.TableSelect += TableSelect;
      _view.About += About;
      _view.Exit += Exit;
    }

    private void TableSelect()
    {
      if (_view.ComboSelectedItem == Entities.Счета.ToString())
      {
        Controller.Run<BillsPresenter>();
        _view.Close();
      }
      else if (_view.ComboSelectedItem == Entities.Пользователи.ToString())
      {
        Controller.Run<UsersPresenter>();
        _view.Close();
      }
      else if (_view.ComboSelectedItem == Entities.Банки.ToString())
      {
        Controller.Run<BanksPresenter>();
        _view.Close();
      }
    }
  }
}
