namespace Smdb.Core.Movies
{
    public class MovieCreateRequest
    {
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Director { get; set; } = string.Empty;
    }
}
