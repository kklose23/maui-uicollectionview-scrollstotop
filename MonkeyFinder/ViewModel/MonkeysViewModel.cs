namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
  public MonkeysViewModel()
  {
    Items = new List<string>()
    {
      "item with long name 1",
      "item with long name 2",
      "item with long name 3",
      "item with long name 4",
    };
  }

  [ObservableProperty]
  private IEnumerable<string> _items;
}
