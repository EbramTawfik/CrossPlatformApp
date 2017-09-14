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

        }
    }
}
