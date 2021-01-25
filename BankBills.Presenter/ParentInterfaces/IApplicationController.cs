namespace BankBills.Presenter
{
  public interface IApplicationController
  {
    IApplicationController RegisterView<TView, TImplementation>() where TImplementation : class, TView where TView : IView;

    IApplicationController RegisterInstance<TArgument>(TArgument instance);

    void Run<TPresenter>() where TPresenter : class, IPresenter;
  }
}