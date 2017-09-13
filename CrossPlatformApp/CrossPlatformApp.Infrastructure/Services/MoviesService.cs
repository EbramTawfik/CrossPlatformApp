using CrossPlatformApp.Infrastructure.Model;
using CrossPlatformApp.Infrastructure.RestClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrossPlatformApp.Infrastructure.Services
{
    class MoviesService
    {
        public async Task<List<Movie>> GetMoviesAsync(string uri)
        {
            RestClient<API_Response> restClient = new RestClient<API_Response>();
            var apiResponse = await restClient.GetAsync(uri);
            var moviesList = apiResponse.Movies;
            return moviesList;
        }
    }
}
