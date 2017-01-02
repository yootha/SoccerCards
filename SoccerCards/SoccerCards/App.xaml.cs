using Prism.Unity;
using SoccerCards.Views;

namespace SoccerCards
{
  public partial class App : PrismApplication
  {
    public App(IPlatformInitializer initializer = null) : base(initializer) { }

    protected override void OnInitialized()
    {
      InitializeComponent();

      NavigationService.NavigateAsync("MainPage");
    }

    protected override void RegisterTypes()
    {
      Container.RegisterTypeForNavigation<MainPage>();      
      Container.RegisterTypeForNavigation<TeamSelectionPage>();
      Container.RegisterTypeForNavigation<GameSettingsPage>();
      Container.RegisterTypeForNavigation<FixturesPage>();
      Container.RegisterTypeForNavigation<PreGamePage>();
      Container.RegisterTypeForNavigation<GamePage>();
      Container.RegisterTypeForNavigation<PostGamePage>();
    }
  }
}
