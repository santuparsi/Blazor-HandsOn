using HandsOnBlazorInvokeAPI.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace HandsOnBlazorInvokeAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _client;
       

        public MovieService(HttpClient client)
        {
            _client = client;
           
        }

        public async void Add(Movie movie)
        {
            var content = JsonSerializer.Serialize(movie);
            var requestContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/api/Movie/AddMovie", requestContent);
        }

        public async void Delete(int id)
        {
            var response = await _client.DeleteAsync("/api/Movie/DeleteMovie/" + id);
            var content = await response.Content.ReadAsStringAsync();
        }

        public  async Task<Movie> Get(int id)
        {
           // _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "token");
            var response =   await _client.GetAsync("/api/Movie/GetMovieById/"+id);
            var content =  await response.Content.ReadAsStringAsync();
            var movie = JsonSerializer.Deserialize<Movie>(content);
            return movie;
        }

    

        public async void Update(Movie movie)
        {
            var content = JsonSerializer.Serialize(movie);
            var requestContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync("/api/Movie/EditMovie", requestContent);
        }

        public async Task<List<Movie>> GetAll()
        {
            var response = await _client.GetAsync("/api/Movie/GetAllMovies");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var movies = JsonSerializer.Deserialize<List<Movie>>(content);
            return movies;
        }
    }
}
