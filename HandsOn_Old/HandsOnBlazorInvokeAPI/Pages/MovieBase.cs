using HandsOnBlazorInvokeAPI.Models;
using HandsOnBlazorInvokeAPI.Services;
using Microsoft.AspNetCore.Components;

namespace HandsOnBlazorInvokeAPI.Pages
{
    public class MovieBase:ComponentBase
    {
        public List<Movie> movies = new List<Movie>();
        [Inject]
        public IMovieService MovieService { get; set; }
        public Movie movie=new Movie();

        protected async override Task OnInitializedAsync()
        {
            movies = await MovieService.GetAll();
        }
        protected  async Task AddMovie()
        {
             MovieService.Add(movie);
            movies = await MovieService.GetAll();
        }
        protected async Task UpdateMovie()
        {
            MovieService.Update(movie);
            movies = await MovieService.GetAll();
        }
        protected async Task DeleteMovie()
        {
            int movieId = movie.movieId;
            MovieService.Delete(movieId);
            movies = await MovieService.GetAll();
        }
        protected async Task GetMovie()
        {
            int movieId = movie.movieId;
            movie=   await MovieService.Get(movieId);
        }
    }
}
