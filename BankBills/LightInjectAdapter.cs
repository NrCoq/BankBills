using BankBills.Presenter;
using LightInject;

namespace BankBills
{
  public sealed class LightInjectAdapter : IContainer
  {
    private readonly ServiceContainer _container = new ServiceContainer();

    public void Register<TArgument, TImplementation>() where TImplementation : TArgument
    {
      _container.Register<TArgument, TImplementation>();
    }

    public void Register<TArgument>()
    {
      _container.Register<TArgument>();
    }

    public void RegisterInstance<T>(T instance)
    {
      _container.RegisterInstance(instance);
    }

    public TArgument Resolve<TArgument>()
    {
      return _container.GetInstance<TArgument>();
    }

    public bool IsRegistered<TArgument>()
    {
      return _container.CanGetInstance(typeof(TArgument), string.Empty);
    }
  }
}