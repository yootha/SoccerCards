using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace SoccerCards.ViewModels
{
  public class TeamSelectionPageViewModel : BindableBase
  {
    INavigationService _navigationService;

    private string _value = "parameter";
    public string Value
    {
      get { return _value; }
      set { SetProperty(ref _value, value); }
    }

    public DelegateCommand NavigateCommand { get; private set; }

    public TeamSelectionPageViewModel(INavigationService navigationService)
    {
      _navigationService = navigationService;
      NavigateCommand = new DelegateCommand(Navigate);
    }

    private void Navigate()
    {
      var p = new NavigationParameters();
      p.Add("id", Value);

      _navigationService.NavigateAsync("GameSettingsPage", p);
    }

  }
}
