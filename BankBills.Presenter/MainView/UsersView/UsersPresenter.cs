using BankBills.Model;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BankBills.Presenter
{
  public class UsersPresenter : BasePresenter<IUsersView>
  {
    private readonly SaveFileDialog _saveFile = new SaveFileDialog();

    private readonly IUsersView _view;

    private Users _users;

    private string _filePath;

    public UsersPresenter(IApplicationController controller, IUsersView view) : base(controller, view)
    {
      _users = new Users();
      _view = view;
      foreach (Entities entity in Enum.GetValues(typeof(Entities)))
      {
        _view.ComboItem = entity.ToString();
        if (entity == Entities.Пользователи)
        {
          _view.ComboSelectedItem = entity.ToString();
        }
      }
      _view.TableFill(_users.ToArray());
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
          IEnumerable<Users> users = UsersRepository.GetList();
          foreach (Users user in users)
          {
            sw.WriteLine(user.ToString());
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
      if (string.IsNullOrEmpty(_view.Name))
      {
        throw new ArgumentNullException($"Name");
      }

      _users = new Users()
      {
        Id = Int32.Parse(_view.Id),
        Name = _view.Name
      };

      if (UsersRepository.IsCreated(_users))
      {
        UsersRepository.Update(_users);
      }
      _view.TableFill(_users.ToArray());
    }

    private void Delete()
    {
      if (string.IsNullOrEmpty(_view.Id))
      {
        throw new ArgumentNullException($"Id");
      }
      if (string.IsNullOrEmpty(_view.Name))
      {
        throw new ArgumentNullException($"Name");
      }

      _users = new Users()
      {
        Id = Int32.Parse(_view.Id),
        Name = _view.Name
      };

      if (UsersRepository.IsCreated(_users))
      {
        UsersRepository.Delete(_users);
      }
      else
      {
        throw new ArgumentException("Запись не найдена в таблице!");
      }
      _view.TableFill(_users.ToArray());
    }
    private void Add()
    {
      if (string.IsNullOrEmpty(_view.Name))
      {
        throw new ArgumentNullException($"Name");
      }

      _users = new Users()
      {
        Name = _view.Name
      };
      if (!UsersRepository.IsCreated(_users))
      {
        UsersRepository.Insert(_users);
        _view.TableFill(_users.ToArray());
      }
      
    }
  }
}
