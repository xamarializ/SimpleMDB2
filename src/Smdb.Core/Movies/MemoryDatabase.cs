namespace Smdb.Core.Movies;

public class MemoryDatabase
{
  private List<Movie> movies = new();
  private int nextId = 1;

  public MemoryDatabase()
  {
    SeedMovies();
    // ensure nextId starts after the seeded movies
    if (movies.Count > 0)
      nextId = movies.Max(m => m.Id) + 1;
  }
  public List<Movie> GetAllMovies()
  {
    return movies;
  }

  public Movie? GetMovieById(int id)
  {
    return movies.FirstOrDefault(m => m.Id == id);
  }

  private void SeedMovies()
  {
    movies.AddRange(new Movie[]
    {
            new Movie { Id = 1, Title = "The Godfather", Year = 1972, Description = "A mafia patriarch hands the family empire to his reluctant son." },
            new Movie { Id = 2, Title = "The Godfather Part II", Year = 1974, Description = "Michael consolidates power as flashbacks trace Vito Corleone’s rise." },
            new Movie { Id = 3, Title = "The Dark Knight", Year = 2008, Description = "Batman faces the Joker, who pushes Gotham into chaos." },
            new Movie { Id = 4, Title = "The Shawshank Redemption", Year = 1994, Description = "An innocent banker forms a life-saving friendship in prison." },
            new Movie { Id = 5, Title = "Pulp Fiction", Year = 1994, Description = "Interlocking LA crime stories unfold with dark humor." },
            new Movie { Id = 6, Title = "Schindler's List", Year = 1993, Description = "A businessman saves Jewish workers during the Holocaust." },
            new Movie { Id = 7, Title = "The Lord of the Rings: The Return of the King", Year = 2003, Description = "The final push to destroy the One Ring decides Middle-earth’s fate." },
            new Movie { Id = 8, Title = "Fight Club", Year = 1999, Description = "An insomnia-plagued worker joins a charismatic anarchist’s secret club." },
            new Movie { Id = 9, Title = "Forrest Gump", Year = 1994, Description = "A kind man unwittingly drifts through historic American moments." },
            new Movie { Id = 10, Title = "Inception", Year = 2010, Description = "A thief enters dreams to plant an idea in a target’s mind." },
            new Movie { Id = 11, Title = "The Matrix", Year = 1999, Description = "A hacker learns reality is a simulated prison for humanity." },
            new Movie { Id = 12, Title = "Se7en", Year = 1995, Description = "Two detectives hunt a killer using the seven deadly sins." },
            new Movie { Id = 13, Title = "Goodfellas", Year = 1990, Description = "Henry Hill’s rise and fall inside the New York mob." },
            new Movie { Id = 14, Title = "The Silence of the Lambs", Year = 1991, Description = "An FBI trainee consults Hannibal Lecter to catch a serial killer." },
            new Movie { Id = 15, Title = "Star Wars: Episode IV – A New Hope", Year = 1977, Description = "A farm boy joins rebels to destroy the Empire’s Death Star." },
            new Movie { Id = 16, Title = "The Empire Strikes Back", Year = 1980, Description = "The Rebels scatter as Luke confronts Darth Vader." },
            new Movie { Id = 17, Title = "Interstellar", Year = 2014, Description = "Astronauts travel through a wormhole to save a dying Earth." },
            new Movie { Id = 18, Title = "Parasite", Year = 2019, Description = "A poor family infiltrates a wealthy household with unforeseen fallout." },
            new Movie { Id = 19, Title = "Spirited Away", Year = 2001, Description = "A girl navigates a spirit bathhouse to free her parents." },
            new Movie { Id = 20, Title = "City of God", Year = 2002, Description = "Two boys take diverging paths amid Rio’s gang wars." },
            new Movie { Id = 21, Title = "Saving Private Ryan", Year = 1998, Description = "A squad risks everything to bring a paratrooper home." },
            new Movie { Id = 22, Title = "The Green Mile", Year = 1999, Description = "Death-row guards encounter a prisoner with miraculous gifts." },
            new Movie { Id = 23, Title = "Gladiator", Year = 2000, Description = "A betrayed general becomes Rome’s fiercest arena fighter." },
            new Movie { Id = 24, Title = "The Lion King", Year = 1994, Description = "An exiled lion cub returns to claim his destiny." },
            new Movie { Id = 25, Title = "Back to the Future", Year = 1985, Description = "A teen time-travels and risks erasing his own existence." },
            new Movie { Id = 26, Title = "The Departed", Year = 2006, Description = "An infiltrator and a mole play cat-and-mouse in Boston." },
            new Movie { Id = 27, Title = "Whiplash", Year = 2014, Description = "A jazz drummer endures a brutal mentor in pursuit of greatness." },
            new Movie { Id = 28, Title = "The Prestige", Year = 2006, Description = "Rival magicians wage a dangerous war of one-upmanship." },
            new Movie { Id = 29, Title = "The Usual Suspects", Year = 1995, Description = "A survivors’ tale hints at the legend of Keyser Söze." },
            new Movie { Id = 30, Title = "Terminator 2: Judgment Day", Year = 1991, Description = "A reprogrammed cyborg protects the future leader of humanity." },
            new Movie { Id = 31, Title = "Alien", Year = 1979, Description = "A crew is stalked by a lethal lifeform aboard a spaceship." },
            new Movie { Id = 32, Title = "Aliens", Year = 1986, Description = "Ripley returns to face a hive of xenomorphs on LV - 426." },
            new Movie { Id = 33, Title = "Blade Runner", Year = 1982, Description = "A detective hunts rogue androids in a neon - soaked future." },
            new Movie { Id = 34, Title = "Apocalypse Now", Year = 1979, Description = "A captain journeys upriver to terminate a renegade officer." },
            new Movie { Id = 35, Title = "One Flew Over the Cuckoo's Nest", Year = 1975, Description = "A rebel patient challenges a tyrannical nurse in a psych ward." },
            new Movie { Id = 36, Title = "Taxi Driver", Year = 1976, Description = "A disturbed NYC cabbie spirals toward violence." },
            new Movie { Id = 37, Title = "Oldboy", Year = 2003, Description = "A man seeks answers after 15 years of inexplicable captivity." },
            new Movie { Id = 38, Title = "Amélie", Year = 2001, Description = "A shy Parisian decides to secretly improve others’ lives." },
            new Movie { Id = 39, Title = "The Pianist", Year = 2002, Description = "A Jewish pianist struggles to survive Warsaw’s ghetto." },
            new Movie { Id = 40, Title = "American Beauty", Year = 1999, Description = "A suburban man’s midlife crisis upends his family." },
            new Movie { Id = 41, Title = "No Country for Old Men", Year = 2007, Description = "A stolen briefcase triggers relentless pursuit across Texas." },
            new Movie { Id = 42, Title = "There Will Be Blood", Year = 2007, Description = "An oilman’s ambition consumes everything around him." },
            new Movie { Id = 43, Title = "Mad Max: Fury Road", Year = 2015, Description = "A desert chase pits a warlord against a defiant road warrior." },
            new Movie { Id = 44, Title = "La La Land", Year = 2016, Description = "A musician and an actress chase dreams in modern LA." },
            new Movie { Id = 45, Title = "Joker", Year = 2019, Description = "A marginalized comedian’s breakdown sparks violent unrest." },
            new Movie { Id = 46, Title = "Avengers: Infinity War", Year = 2018, Description = "Earth’s heroes battle Thanos for the fate of half the universe." },
            new Movie { Id = 47, Title = "Avengers: Endgame", Year = 2019, Description = "Survivors attempt a time-heist to undo cosmic devastation." },
            new Movie { Id = 48, Title = "Toy Story", Year = 1995, Description = "Rivalry between a cowboy doll and a space ranger turns to friendship." },
            new Movie { Id = 49, Title = "Inside Out", Year = 2015, Description = "A girl’s emotions guide her through a difficult move." },
            new Movie { Id = 50, Title = "The Social Network", Year = 2010, Description = "Facebook’s founding sparks friendship and legal battles." }
    });
  }

  public int AddMovie(Movie movie)
  {
    movie.Id = nextId++;
    movies.Add(movie);
    return movie.Id;
  }

  public bool UpdateMovie(int id, Movie movie)
  {
    var existing = GetMovieById(id);
    if (existing == null)
      return false;

    existing.Title = movie.Title;
    existing.Description = movie.Description;
    existing.Year = movie.Year;
    return true;
  }

  public bool DeleteMovie(int id)
  {
    var movie = GetMovieById(id);
    if (movie == null)
      return false;

    movies.Remove(movie);
    return true;
  }
}
