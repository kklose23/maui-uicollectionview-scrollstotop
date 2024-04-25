using CommunityToolkit.Maui.Behaviors;
#if ANDROID
using Microsoft.Maui.Platform;
#elif (IOS)    
using UIKit;
#endif

namespace MonkeyFinder.Behaviors;

public class HideSoftInputOnTappedViewBehavior : BaseBehavior<View>
{

  private readonly TapGestureRecognizer _tapGestureRecognizer;
  public View Grid { get; private set; }

  public HideSoftInputOnTappedViewBehavior()
  {
    _tapGestureRecognizer = new TapGestureRecognizer();
    _tapGestureRecognizer.Tapped += OnTapped;
  }

  protected override void OnAttachedTo(View grid)
  {
    Grid = grid;    
    base.OnAttachedTo(grid);    
    Grid.GestureRecognizers.Add(_tapGestureRecognizer);
  }
  
  protected override void OnDetachingFrom(View grid)
  {
    Grid.GestureRecognizers.Remove(_tapGestureRecognizer);
    Grid = null;    
    base.OnDetachingFrom(grid);
  }

  private void OnTapped(object sender, TappedEventArgs e)
  {
#if (ANDROID)
    if (Platform.CurrentActivity.CurrentFocus != null)
    {      
      Platform.CurrentActivity.HideKeyboard(Platform.CurrentActivity.CurrentFocus);
      Platform.CurrentActivity.CurrentFocus.ClearFocus();
    }    
#elif (IOS)
    if (UIApplication.SharedApplication?.KeyWindow != null)
    {
      UIApplication.SharedApplication.KeyWindow.EndEditing(true);
    }
#endif
  }
}
