namespace BankBills.Presenter
{
  public interface IContainer
  {
    void Register<TArgument, TImplementation>() where TImplementation : TArgument;

    void Register<TArgument>();

    void RegisterInstance<T>(T instance);

    TArgument Resolve<TArgument>();

    bool IsRegistered<TArgument>();
  }
}