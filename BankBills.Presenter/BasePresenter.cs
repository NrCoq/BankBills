namespace BankBills.Presenter
{
  public abstract class BasePresenter<TView> : IPresenter where TView : IView
  {
    public enum Entities
    {
      Счета = 1,
      Пользователи,
      Банки,
    }

    protected TView View { get; }

    protected IApplicationController Controller { get; }

    protected BasePresenter()
    {
    }

    protected BasePresenter(IApplicationController controller, TView view)
    {
      Controller = controller;
      View = view;
    }

    public void Run()
    {
      View.Show();
    }

    public void About()
    {
      Controller.Run<AboutPresenter>();
    }

    public void Exit()
    {
      View.Close();
    }
  }
}
