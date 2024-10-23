namespace Tinda_Hunt
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private async void OnBuyItemTapped(object sender, EventArgs e)
        {
            try
            {
                // Navigate to the Buy Item page or perform any desired action
                await DisplayAlert("Buy Item", "You tapped on Buy Item!", "OK");
                await Navigation.PushAsync(new BuyItemsPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Navigation Error", ex.Message, "OK");
            }
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
