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