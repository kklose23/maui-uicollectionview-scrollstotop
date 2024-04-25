using MonkeyFinder.Behaviors;

namespace MonkeyFinder.Views;

public partial class MainPage : ContentPage
{
  public MainPage(MonkeysViewModel viewModel)
  {
    InitializeComponent();
    BindingContext = viewModel;

    Shell.SetSearchHandler(this, new SearchHandler());
    this.Content.Behaviors.Add(new HideSoftInputOnTappedViewBehavior());
  }
}



