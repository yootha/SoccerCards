using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoccerCards.ViewModels
{
  public class MainPageViewModel : BindableBase
  {

    INavigationService _navigationService;

    private string _value = "paramGameType";

    public string Value
    {
      get { return _value; }
      set { SetProperty(ref _value, value); }
    }

    public DelegateCommand NavigateCommand { get; private set; }    

    public MainPageViewModel(INavigationService navigationService)
    {
      _navigationService = navigationService;
      NavigateCommand = new DelegateCommand(Navigate);
    }

    private void Navigate()
    {
      var p = new NavigationParameters();
      p.Add("id", Value);

      _navigationService.NavigateAsync("TeamSelectionPage", p);
    }

  }
}
