namespace Tinda_Hunt
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {

            InitializeComponent();
        }

             protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(4000);

            ShowLoading(true);

            await Task.Delay(4000);

            ShowLoading(false);

            Application.Current.MainPage = new NavigationPage(new HomePage());
        }


        private void ShowLoading(bool isLoading)
        {
            LoadingOverlay.IsVisible = isLoading;


        }
    }

}

