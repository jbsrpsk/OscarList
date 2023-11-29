record OsMovies(
    string Name,
    int Year,
    string Director,
    string[] Actors,
    bool exWinner,
    Genre Genre
)
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

record Director(
    string Name,
    int Movies
)
record Movie(
    string Name,
    int RunLength,
    Genre Genre,
    Director Director,
    float IMDbRating
)

let moviesData = [
    {Title = "CODA"; Duration = 111; Genre = Drama; FilmDirector = findDirectorByFullName "Sian Heder"; IMDbScore = 8.1}
    {Title = "Belfast"; Duration = 98; Genre = Comedy; FilmDirector = findDirectorByFullName "Kenneth Branagh"; IMDbScore = 7.3}
    {Title = "Don’t Look Up"; Duration = 138; Genre = Comedy; FilmDirector = findDirectorByFullName "Adam McKay"; IMDbScore = 7.2}
    {Title = "Drive My Car"; Duration = 179; Genre = Drama; FilmDirector = findDirectorByFullName "Ryusuke Hamaguchi"; IMDbScore = 7.6}
    {Title = "Dune"; Duration = 155; Genre = Fantasy; FilmDirector = findDirectorByFullName "Denis Villeneuve"; IMDbScore = 8.1}
    {Title = "King Richard"; Duration = 144; Genre = Sport; FilmDirector = findDirectorByFullName "Reinaldo Marcus Green"; IMDbScore = 7.5}
    {Title = "Licorice Pizza"; Duration = 133; Genre = Comedy; FilmDirector = findDirectorByFullName "Paul Thomas Anderson"; IMDbScore = 7.4}
    {Title = "Nightmare Alley"; Duration = 150; Genre = Thriller; FilmDirector = findDirectorByFullName "Guillermo Del Toro"; IMDbScore = 7.1}
]