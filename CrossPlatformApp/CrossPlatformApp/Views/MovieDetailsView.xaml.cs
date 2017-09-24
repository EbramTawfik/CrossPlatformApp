using CrossPlatformApp.Infrastructure.Model;
using CrossPlatformApp.Infrastructure.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatformApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailsView : ContentPage
    {
        MovieDetailsViewModel Vm;
        public MovieDetailsView(Movie selectedMovie)
        {
            InitializeComponent();
            Vm = new MovieDetailsViewModel(selectedMovie);
            BindingContext = Vm;
        }
    }
}
