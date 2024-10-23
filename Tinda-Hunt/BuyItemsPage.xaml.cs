namespace Tinda_Hunt
{

    public partial class BuyItemsPage : ContentPage
    {
        public BuyItemsPage()
        {
            InitializeComponent();
        }
        private async void OnCannedFoodClicked(object sender, EventArgs e)
        {
            try
            {
                // Check if Navigation is null
                if (Navigation == null)
                {
                    await DisplayAlert("Error", "Navigation is null!", "OK");
                    return;
                }

                // Check if the page creation is causing an issue
                var cannedFoodPage = new CannedFoodPage();
                if (cannedFoodPage == null)
                {
                    await DisplayAlert("Error", "CannedFoodPage is null!", "OK");
                    return;
                }

                // If everything is fine, proceed with navigation
                await Navigation.PushAsync(cannedFoodPage);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
