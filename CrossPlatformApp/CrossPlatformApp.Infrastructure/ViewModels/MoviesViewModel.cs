using CrossPlatformApp.Infrastructure.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;
using System.Threading.Tasks;
using CrossPlatformApp.Infrastructure.Services;
using System.Diagnostics;

namespace CrossPlatformApp.Infrastructure.ViewModels
{
    public class MoviesViewModel : ViewModelBase
    {


        #region Properties
        private ObservableCollection<Movie> _moviesList;

        public ObservableCollection<Movie> MoviesList
        {
            get
            {
                if (_moviesList == null)
                {
                    _moviesList = new ObservableCollection<Movie>();
                }
                return _moviesList;
            }
            set
            {
                _moviesList = value;
                RaisePropertyChanged(() => MoviesList);
            }
        }

        private ICommand _getMoviesCommand;

        public ICommand GetMoviesCommand
        {
            get
            {
                return _getMoviesCommand ?? (_getMoviesCommand = new RelayCommand(async () => await GetMovies()));
            }
        }


        private bool _isbusy;

        public bool IsBusy
        {
            get { return _isbusy; }
            set
            {
                _isbusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }
        #endregion



        #region Methods
        private async Task GetMovies()
        {
            try
            {
                if (IsBusy)
                {
                    return;
                }
                IsBusy = true;
                var moviesService = new MoviesService();

                var movies = await moviesService.GetMoviesAsync(Constants.MoviesUri);
                MoviesList.Clear();
                foreach (var movie in movies)
                {
                    MoviesList.Add(movie);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }
        #endregion
    }
}
