using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankBills.Model.Tests
{
  [TestClass]
  public class BanksRepositoryTests
  {
    private Banks _banks;
    [TestInitialize]
    public void TestInitialize()
    {
      _banks = new Banks()
      {
        Account = "111111111",
        Name = "Test"
      };
      if (BanksRepository.IsCreated(_banks))
      {
        BanksRepository.Update(_banks);
      }
      else
      {
        BanksRepository.Insert(_banks);
      }
    }

    [TestMethod]
    public void Add()
    {
      bool actual = BanksRepository.IsCreated(_banks);
      BanksRepository.Delete(_banks);
      Assert.AreEqual(true, actual);
    }

    [TestMethod]
    public void Update()
    {
      string expected = "Bank";

      _banks.Name = "Bank";
      BanksRepository.Update(_banks);
      Banks banks = BanksRepository.Get(_banks);
      string actual = banks.Name;
      BanksRepository.Delete(_banks);

      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Get()
    {
      string expectedAccount = "111111111";
      string expectedName = "Test";

      Banks banks = BanksRepository.Get(_banks);
      string actualAccount = banks.Account;
      string actualName = banks.Name;

      Assert.AreEqual(expectedAccount, actualAccount);
      Assert.AreEqual(expectedName, actualName);
    }

    [TestMethod]
    public void Delete()
    {
      BanksRepository.Delete(_banks);
      bool actual = BanksRepository.IsCreated(_banks);

      Assert.AreEqual(false, actual);
    }
  }
}
