namespace Tinda_Hunt
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OnBuyItemTapped(object sender, EventArgs e)
        {
            // Navigate to the Buy Item page or perform any desired action
            DisplayAlert("Buy Item", "You tapped on Buy Item!", "OK");

            //await Shell.Current.GoToAsync("BuyItemPage"); lagyan mo ng bagong page name BuyItemPage Ganun din sa iba
        }

        private void OnNearestStoreTapped(object sender, EventArgs e)
        {
            // Navigate to the Nearest Store page or perform any desired action
            DisplayAlert("Nearest Store", "You tapped on Nearest Store!", "OK");
        }

        private void OnPriceTapped(object sender, EventArgs e)
        {
            // Navigate to the Price page or perform any desired action
            DisplayAlert("Price", "You tapped on Price!", "OK");
        }
    }
}
