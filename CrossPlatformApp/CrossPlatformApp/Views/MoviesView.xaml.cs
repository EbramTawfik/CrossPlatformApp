using CrossPlatformApp.Infrastructure.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatformApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoviesView : ContentPage
    {
        MoviesViewModel Vm;
        public MoviesView()
        {
            InitializeComponent();
            Vm = new MoviesViewModel();
            BindingContext = Vm;
            Vm.GetMoviesCommand.Execute(null);
            MoviesList.ItemSelected += MoviesList_ItemSelected;
        }

        private void MoviesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (Vm.SelectedMovie != null)
            {
                Navigation.PushAsync(new MovieDetailsView(Vm.SelectedMovie));
            }
        }
    }
}
