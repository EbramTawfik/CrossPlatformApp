using System.ComponentModel;
using Xamarin.Forms;
using CrossPlatformApp.Infrastructure.ViewModels;
using CrossPlatformApp.Infrastructure.Model;

namespace CrossPlatformApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        MoviesViewModel viewModel;
        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new MoviesViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Movie;
            if (item == null)
                return;


            await Navigation.PushAsync(new ItemDetailPage(new MovieDetailsViewModel(item)));
            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();


            if (viewModel.MoviesList.Count == 0)
                viewModel.GetMoviesCommand.Execute(null);
        }
    }
}