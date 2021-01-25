using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankBills.Model.Tests
{
  [TestClass]
  public class BillsRepositoryTests
  {
    private Bills _bills;

    [TestInitialize]
    public void TestInitialize()
    {
      _bills = new Bills()
      {
        Id = 321,
        UserName = "Oleg",
        Account = "000",
        OperationDate = "29.05.2020",
        Description = "test",
        Amount = 16
      };
      if (BillsRepository.IsCreated(_bills))
      {
        BillsRepository.Update(_bills);
      }
      else
      {
        BillsRepository.Insert(_bills);
      }
    }

    [TestMethod]
    public void Add()
    {
      bool actual = BillsRepository.IsCreated(_bills);
      BillsRepository.Delete(_bills);

      Assert.AreEqual(true, actual);
    }

    [TestMethod]
    public void Update()
    {
      string expected = "Oleg";

      _bills.UserName = "Oleg";
      BillsRepository.Update(_bills);
      Bills Bills = BillsRepository.Get(_bills);
      string actual = Bills.UserName;
      BillsRepository.Delete(_bills);

      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Get()
    {
      int expectedId = 321;
      string expectedUserName = "Oleg";
      string expectedAccount = "000";
      string expectedOperationDate = "29.05.2020";
      string expectedDescription = "test";
      double expectedAmount = 4;

      Bills Bills = BillsRepository.Get(_bills);
      int actualId = Bills.Id;
      string actualUserName = Bills.UserName;
      string actualAccount = Bills.Account;
      string actualOperationDate = Bills.OperationDate;
      string actualDescription = Bills.Description;
      double actualAmount = Bills.Amount;

      Assert.AreEqual(expectedId, actualId);
      Assert.AreEqual(expectedUserName, actualUserName);
      Assert.AreEqual(expectedAccount, actualAccount);
      Assert.AreEqual(expectedOperationDate, actualOperationDate);
      Assert.AreEqual(expectedDescription, actualDescription);
      Assert.AreEqual(expectedAmount, actualAmount);
    }

    [TestMethod]
    public void Delete()
    {
      BillsRepository.Delete(_bills);
      bool actual = BillsRepository.IsCreated(_bills);

      Assert.AreEqual(false, actual);
    }
  }
}
