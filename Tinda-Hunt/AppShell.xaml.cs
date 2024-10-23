namespace Tinda_Hunt
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("MainPage", typeof(MainPage));
            Routing.RegisterRoute("HomePage", typeof(HomePage));
            Routing.RegisterRoute("BuyItemsPage", typeof(BuyItemsPage));
            Routing.RegisterRoute("CannedFoodPage", typeof(CannedFoodPage));
        }
    }
}
