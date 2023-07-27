using Prism.Navigation;

namespace PrismFlyoutCanNavigate;

public class MainViewModel : IConfirmNavigationAsync
{
    public Task<bool> CanNavigateAsync(INavigationParameters parameters)
    {
        if(parameters.GetNavigationMode() == Prism.Navigation.NavigationMode.Back)
        {
            // gets never called
            return Task.FromResult(false);
        }

        return Task.FromResult(true);
    }
}
