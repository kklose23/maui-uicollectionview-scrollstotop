using MonkeyFinder.Views;

namespace MonkeyFinder;

public partial class AppShell : Shell
{
  public AppShell(AppShellViewModel viewModel)
  {
    InitializeComponent();
    BindingContext = viewModel;
    //Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
  }
}