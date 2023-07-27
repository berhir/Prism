namespace PrismFlyoutCanNavigate;

public partial class MainPage : FlyoutPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    //protected override bool OnBackButtonPressed()
    //{
    //    // The FlyoutPage is the container and OnBackButtonPressed gets also called when navigating back in the details navigation page
    //    if (Detail is NavigationPage navPage && (navPage.Navigation.NavigationStack.Count > 1 || navPage.Navigation.ModalStack.Count > 1))
    //    {
    //        return base.OnBackButtonPressed();
    //    }

    //    return true;
    //}
}
