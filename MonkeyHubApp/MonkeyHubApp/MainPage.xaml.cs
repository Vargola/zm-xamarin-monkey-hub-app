using MonkeyHubApp.Services;
using MonkeyHubApp.ViewModels;
using Xamarin.Forms;

namespace MonkeyHubApp
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel ViewModel => BindingContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
            //var monkeyHubApiService = DependencyService.Get<IMonkeyHubApiService>();
            //BindingContext = new MainViewModel(monkeyHubApiService);
            BindingContext = new MainViewModel(new MonkeyHubApiService());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if(ViewModel != null)
            {
                await ViewModel.LoadAsync();
            }
        }
    }
}
