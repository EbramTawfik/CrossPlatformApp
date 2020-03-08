using System.ComponentModel;
using Xamarin.Forms;
using CrossPlatformApp.Infrastructure.ViewModels;

namespace CrossPlatformApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        MovieDetailsViewModel viewModel;
        public ItemDetailPage(MovieDetailsViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

   
    }
}