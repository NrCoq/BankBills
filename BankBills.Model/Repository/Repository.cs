using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;

namespace BankBills.Model
{
  public abstract class Repository<TEntity> where TEntity : new()
  {
    public static void DataBaseChecking()
    {
      string connection = Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
      if (!File.Exists(connection))
      {
        SQLiteConnection.CreateFile(connection);
        connection = "Data Source=" + Environment.CurrentDirectory + ConfigurationManager.ConnectionStrings["SQLiteConnection"];
        using (SQLiteConnection db = new SQLiteConnection(connection))
        {
          db.Open();
          string cmd = "PRAGMA foreign_keys = ON";
          SQLiteCommand command = new SQLiteCommand(cmd, db);
          command.ExecuteNonQuery();

          cmd = "CREATE TABLE 'Banks' ( " +
                "Name TEXT NOT NULL, " +
                "Account TEXT NOT NULL UNIQUE, " +
                "PRIMARY KEY('Account'))";
          command = new SQLiteCommand(cmd, db);
          command.ExecuteNonQuery();

          cmd = "CREATE TABLE 'Users' ( " +
                "Id INTEGER NOT NULL UNIQUE, " +
                "Name  TEXT NOT NULL, " +
                "PRIMARY KEY('Id'))";
          command = new SQLiteCommand(cmd, db);
          command.ExecuteNonQuery();

          cmd = "CREATE TABLE 'Bills' ( " +
                "Id INTEGER NOT NULL UNIQUE, " +
                "UserName  TEXT NOT NULL, " +
                "Account TEXT NOT NULL UNIQUE, " +
                "OperationDate TEXT NOT NULL, " +
                "Description TEXT NOT NULL, " +
                "Amount  REAL NOT NULL, " +
                "PRIMARY KEY('Id'))";
          command = new SQLiteCommand(cmd, db);
          command.ExecuteNonQuery();
        }
      }
    }

    public static void Insert(TEntity entity)
    {
      throw new Exception("Override this method!");
    }

    public static void Update(TEntity entity)
    {
      throw new Exception("Override this method!");
    }

    public static IEnumerable<TEntity> GetList()
    {
      throw new Exception("Override this method!");
    }

    public static TEntity Get(TEntity entity)
    {
      throw new Exception("Override this method!");
    }

    public static void Delete(TEntity entity)
    {
      throw new Exception("Override this method!");
    }

    public static bool IsCreated(TEntity entity)
    {
      throw new Exception("Override this method!");
    }
  }
}