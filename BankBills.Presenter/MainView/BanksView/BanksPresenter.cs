using BankBills.Model;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BankBills.Presenter
{
  public class BanksPresenter : BasePresenter<IBanksView>
  {
    private readonly SaveFileDialog _saveFile = new SaveFileDialog();

    private readonly IBanksView _view;

    private Banks _bank;

    private string _filePath;

    public BanksPresenter(IApplicationController controller, IBanksView view) : base(controller, view)
    {
      _bank = new Banks();
      _view = view;
      foreach (Entities entity in Enum.GetValues(typeof(Entities)))
      {
        _view.ComboItem = entity.ToString();
        if (entity == Entities.Банки)
        {
          _view.ComboSelectedItem = entity.ToString();
        }
      }
      _view.TableFill(_bank.ToArray());
      _view.TableSelect += TableSelect;
      _view.Save += Save;
      _view.Delete += Delete;
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
          IEnumerable<Banks> banks = BanksRepository.GetList();
          foreach (Banks bank in banks)
          {
            sw.WriteLine(bank.ToString());
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
        Controller.Run<BillsPresenter>();
        View.Close();
      }
      else if (_view.ComboSelectedItem == Entities.Пользователи.ToString())
      {
        Controller.Run<UsersPresenter>();
        View.Close();
      }
      else if (_view.ComboSelectedItem == Entities.Банки.ToString())
      {
      }
    }
    
    private void Save()
    {
      
      if (string.IsNullOrEmpty(_view.BankName))
      {
        throw new ArgumentNullException($"Bank Name");
      }
      if (string.IsNullOrEmpty(_view.Account))
      {
        throw new ArgumentNullException($"Account");
      }
      _bank = new Banks()
      {
        Name = _view.BankName,
        Account = _view.Account,
        
      };

      if (BanksRepository.IsCreated(_bank))
      {
        BanksRepository.Update(_bank);
      }
      else
      {
        BanksRepository.Insert(_bank);
      }
      _view.TableFill(_bank.ToArray());
    }

    private void Delete()
    {
      if (string.IsNullOrEmpty(_view.BankName))
      {
        throw new ArgumentNullException($"Bank Name");
      }
      if (string.IsNullOrEmpty(_view.Account))
      {
        throw new ArgumentNullException($"Account");
      }

      _bank = new Banks()
      {
        Name = _view.BankName,
        Account = _view.Account,
        
      };

      if (BanksRepository.IsCreated(_bank))
      {
        BanksRepository.Delete(_bank);
      }
      else
      {
        throw new ArgumentException("Запись не найдена в таблице!");
      }
      _view.TableFill(_bank.ToArray());
    }
  }
}
