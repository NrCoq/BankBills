using BankBills.Model;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BankBills.Presenter
{
  public class BillsPresenter : BasePresenter<IBillsView>
  {
    private readonly SaveFileDialog _saveFile = new SaveFileDialog();

    private readonly IBillsView _view;

    private Bills _bills;

    private string _filePath;

    public BillsPresenter(IApplicationController controller, IBillsView view) : base(controller, view)
    {
      _bills = new Bills();
      _view = view;
      foreach (Entities entity in Enum.GetValues(typeof(Entities)))
      {
        _view.ComboItem = entity.ToString();
        if (entity == Entities.Счета)
        {
          _view.ComboSelectedItem = entity.ToString();
        }
      }
      _view.TableFill(_bills.ToArray());
      _view.TableSelect += TableSelect;
      _view.Save += Save;
      _view.Delete += Delete;
      _view.Add += Add;
      _view.About += About;
      _view.Exit += Exit;
      _view.Export += Export;
    }

    private void Export()
    {
      _saveFile.Title = @"Экспорт данных";
      _saveFile.Filter = @"Текстовые документы(*.txt)|*.txt";
      _saveFile.OverwritePrompt = true;
      _saveFile.CheckPathExists = true;
      DialogResult check = _saveFile.ShowDialog();

      if (check == DialogResult.OK)
      {
        _filePath = _saveFile.FileName;
        using (StreamWriter sw = new StreamWriter(_filePath))
        {
          IEnumerable<Bills> bills = BillsRepository.GetList();
          foreach (Bills bill in bills)
          {
            sw.WriteLine(bill.ToString());
          }
        }
        _view.ShowSuccess("Сохранено успешно!");
      }
      else if (check == DialogResult.Cancel)
      {

      }
      else
      {
        throw new Exception("Возникла ошибка!");
      }

      _filePath = null;
    }

    private void TableSelect()
    {
      if (_view.ComboSelectedItem == Entities.Счета.ToString())
      {
      }
      else if (_view.ComboSelectedItem == Entities.Пользователи.ToString())
      {
        Controller.Run<UsersPresenter>();
        View.Close();
      }
      else if (_view.ComboSelectedItem == Entities.Банки.ToString())
      {
        Controller.Run<BanksPresenter>();
        View.Close();
      }
    }

    private void Save()
    {
      if (string.IsNullOrEmpty(_view.Id))
      {
        throw new ArgumentNullException($"Id");
      }
      if (string.IsNullOrEmpty(_view.UserName))
      {
        throw new ArgumentNullException($"User Name");
      }
      if (string.IsNullOrEmpty(_view.Account))
      {
        throw new ArgumentNullException($"Account");
      }
      if (string.IsNullOrEmpty(_view.OperationDate))
      {
        throw new ArgumentNullException($"Operation Date");
      }
      if (string.IsNullOrEmpty(_view.Description))
      {
        throw new ArgumentNullException($"Description");
      }
      if (string.IsNullOrEmpty(_view.Amount))
      {
        throw new ArgumentNullException($"Amount");
      }

      _bills = new Bills()
      {
        Id = Int32.Parse(_view.Id),
        UserName = _view.UserName,
        Account = _view.Account,
        OperationDate = _view.OperationDate,
        Description = _view.Description,
        Amount = double.Parse(_view.Amount)
      };

      if (BillsRepository.IsCreated(_bills))
      {
        BillsRepository.Update(_bills);
      }
      else
      {
        BillsRepository.Insert(_bills);
      }
      _view.TableFill(_bills.ToArray());
    }

    private void Delete()
    {
      if (string.IsNullOrEmpty(_view.Id))
      {
        throw new ArgumentNullException($"Id");
      }
      if (string.IsNullOrEmpty(_view.UserName))
      {
        throw new ArgumentNullException($"User Name");
      }
      if (string.IsNullOrEmpty(_view.Account))
      {
        throw new ArgumentNullException($"Account");
      }
      if (string.IsNullOrEmpty(_view.OperationDate))
      {
        throw new ArgumentNullException($"Operation Date");
      }
      if (string.IsNullOrEmpty(_view.Description))
      {
        throw new ArgumentNullException($"Description");
      }
      if (string.IsNullOrEmpty(_view.Amount))
      {
        throw new ArgumentNullException($"Amount");
      }

      _bills = new Bills()
      {
        Id = Int32.Parse(_view.Id),
        UserName = _view.UserName,
        Account = _view.Account,
        OperationDate = _view.OperationDate,
        Description = _view.Description,
        Amount = double.Parse(_view.Amount)
      };


      if (BillsRepository.IsCreated(_bills))
      {
        BillsRepository.Delete(_bills);
      }
      else
      {
        throw new ArgumentException("Запись не найдена в таблице!");
      }
      _view.TableFill(_bills.ToArray());
    }
    private void Add()
    {
      if (string.IsNullOrEmpty(_view.UserName))
      {
        throw new ArgumentNullException($"User Name");
      }
      if (string.IsNullOrEmpty(_view.Account))
      {
        throw new ArgumentNullException($"Account");
      }
      if (string.IsNullOrEmpty(_view.OperationDate))
      {
        throw new ArgumentNullException($"Operation Date");
      }
      if (string.IsNullOrEmpty(_view.Description))
      {
        throw new ArgumentNullException($"Description");
      }
      if (string.IsNullOrEmpty(_view.Amount))
      {
        throw new ArgumentNullException($"Amount");
      }

      _bills = new Bills()
      {
        UserName = _view.UserName,
        Account = _view.Account,
        OperationDate = _view.OperationDate,
        Description = _view.Description,
        Amount = double.Parse(_view.Amount)
      };

      if (!BillsRepository.IsCreated(_bills))
      {
        BillsRepository.Insert(_bills);
      }
      _view.TableFill(_bills.ToArray());
    }
  }
}
