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