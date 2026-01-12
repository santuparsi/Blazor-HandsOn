using System.ComponentModel.DataAnnotations;

namespace HandsOnBlazorInvokeAPI.Models
{
    public class Movie
    {
        
        public int movieId { get; set; }
        public string title { get; set; }
        public string language { get; set; }
        public int releaseYear { get; set; }
        public string actor { get; set; }
        public string director { get; set; }
    }
}
