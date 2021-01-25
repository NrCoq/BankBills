using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;

namespace BankBills.Model
{
  public sealed class BanksRepository : Repository<Banks>
  {

    public new static void Insert(Banks bank)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string cmd = "PRAGMA foreign_keys = ON";
        SQLiteCommand command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();

        cmd = "INSERT INTO 'Banks' (Name, Account) VALUES ( '" + bank.Name + "', '" + bank.Account + "' )";
        command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();
      }
    }

    public new static void Update(Banks bank)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string cmd = "PRAGMA foreign_keys = ON";
        SQLiteCommand command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();

        cmd = "UPDATE 'Banks' SET Name = '" + bank.Name + "' WHERE Account = '" + bank.Account + "'";
        command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();
      }
    }

    public new static Banks Get(Banks bank)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        Banks _banks = new Banks();
        db.Open();
        string command = "SELECT Name, Account FROM 'Banks' WHERE Account = '" + bank.Account + "'";
        SQLiteCommand com = new SQLiteCommand(command, db);
        SQLiteDataReader r = com.ExecuteReader();
        while (r.Read())
        {
          _banks.Name = r["Name"].ToString();
          _banks.Account = r["Account"].ToString();
        }
        r.Close();
        return _banks;
      }
    }

    public new static IEnumerable<Banks> GetList()
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        List<Banks> banks = new List<Banks>();
        string command = "SELECT Name, Account FROM 'Banks'";
        SQLiteCommand com = new SQLiteCommand(command, db);
        SQLiteDataReader r = com.ExecuteReader();
        while (r.Read())
        {
          Banks bank = new Banks()
          {
            Name = r["Name"].ToString(),
            Account = r["Account"].ToString()
          };
          banks.Add(bank);
        }
        r.Close();
        return banks;
      }
    }

    public new static bool IsCreated(Banks bank)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string command = "SELECT * FROM 'Banks' WHERE Account = '" + bank.Account + "'";
        SQLiteCommand com = new SQLiteCommand(command, db);
        object select = com.ExecuteScalar();
        return @select != null;
      }
    }

    public new static void Delete(Banks bank)
    {
      string connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      using (SQLiteConnection db = new SQLiteConnection(connection))
      {
        db.Open();
        string cmd = "PRAGMA foreign_keys = ON";
        SQLiteCommand command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();

        cmd = "DELETE FROM 'Banks' WHERE Account = '" + bank.Account + "' AND Name = '" + bank.Name + "'";
        command = new SQLiteCommand(cmd, db);
        command.ExecuteNonQuery();
      }
    }
  }
}