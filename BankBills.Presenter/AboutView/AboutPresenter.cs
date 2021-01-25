namespace BankBills.Presenter
{
  public sealed class AboutPresenter : BasePresenter<IAboutView>
  {
    public AboutPresenter(IApplicationController controller, IAboutView view) : base(controller, view)
    {
    }
  }
}