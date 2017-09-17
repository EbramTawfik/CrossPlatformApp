using CrossPlatformApp.Infrastructure.ViewModels;
using System.Windows.Controls;

namespace CrossPlatformApp.WPF.Views
{
    /// <summary>
    /// Interaction logic for MoviesView.xaml
    /// </summary>
    public partial class MoviesView : UserControl
    {
        MoviesViewModel Vm;
        public MoviesView()
        {
            InitializeComponent();
            Vm = new MoviesViewModel();
            this.DataContext=Vm;
            Vm.GetMoviesCommand.Execute(null);
        }
    }
}
