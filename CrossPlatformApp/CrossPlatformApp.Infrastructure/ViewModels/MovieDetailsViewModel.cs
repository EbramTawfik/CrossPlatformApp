using CrossPlatformApp.Infrastructure.Model;
using GalaSoft.MvvmLight;

namespace CrossPlatformApp.Infrastructure.ViewModels
{
    public class MovieDetailsViewModel : ViewModelBase
    {

        public MovieDetailsViewModel(Movie selectedMovie)
        {
            this.SelectedMovie = selectedMovie;
        }

        #region Properties

        private Movie _selectedMovie;
        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                _selectedMovie = value;
                RaisePropertyChanged(() => SelectedMovie);
            }
        }
        #endregion

    }
}
