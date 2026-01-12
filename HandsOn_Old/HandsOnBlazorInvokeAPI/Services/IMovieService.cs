using HandsOnBlazorInvokeAPI.Models;

namespace HandsOnBlazorInvokeAPI.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAll();
        Task<Movie> Get(int id);
        void Update(Movie movie);
        void Delete(int id);
        void Add(Movie movie);
    }
}
