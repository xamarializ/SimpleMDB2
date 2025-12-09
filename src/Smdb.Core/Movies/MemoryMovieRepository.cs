namespace Smdb.Core.Movies;

using Shared.Http;

public class MemoryMovieRepository : IMovieRepository
{
    private MemoryDatabase db;

    public MemoryMovieRepository(MemoryDatabase database)
    {
        db = database;
    }

    public async Task<PagedResult<Movie>?> ReadMovies(int page, int size)
    {
        var allMovies = db.GetAllMovies();
        var totalCount = allMovies.Count;
        var movies = allMovies.Skip((page - 1) * size).Take(size).ToList();

        return await Task.FromResult(new PagedResult<Movie>(totalCount, movies));
    }

    public async Task<Movie?> CreateMovie(Movie newMovie)
    {
        var id = db.AddMovie(newMovie);
        return await Task.FromResult(db.GetMovieById(id));
    }

    public async Task<Movie?> ReadMovie(int id)
    {
        return await Task.FromResult(db.GetMovieById(id));
    }

    public async Task<Movie?> UpdateMovie(int id, Movie newData)
    {
        var success = db.UpdateMovie(id, newData);
        if (!success)
            return await Task.FromResult<Movie?>(null);

        return await Task.FromResult(db.GetMovieById(id));
    }

    public async Task<Movie?> DeleteMovie(int id)
    {
        var movie = db.GetMovieById(id);
        if (movie == null)
            return await Task.FromResult<Movie?>(null);

        db.DeleteMovie(id);
        return await Task.FromResult(movie);
    }
}
