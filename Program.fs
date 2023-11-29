type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

record Director(
    Name: string,
    Movies: int
)

record OsMovies(
    Name: string,
    Year: int,
    Director: Director,
    Genre: Genre
)

let directors = [
    {Name = "Sian Heder"; Movies = 9}
    {Name = "Kenneth Branagh"; Movies = 23}
    {Name = "Adam McKay"; Movies = 27}
    {Name = "Ryusuke Hamaguchi"; Movies = 16}
    {Name = "Denis Villeneuve"; Movies = 24}
    {Name = "Reinaldo Marcus Green"; Movies = 15}
    {Name = "Paul Thomas Anderson"; Movies = 49}
    {Name = "Guillermo Del Toro"; Movies = 22}
]

let findDirectorByName name = directors |> List.find (fun director -> director.Name = name)

let moviesData = [
    {Title = "CODA"; Duration = 111; Genre = Drama; FilmDirector = findDirectorByName "Sian Heder"; IMDbScore = 8.1; Year = 2023}
    {Title = "Belfast"; Duration = 98; Genre = Comedy; FilmDirector = findDirectorByName "Kenneth Branagh"; IMDbScore = 7.3; Year = 2022}
    {Title = "Don’t Look Up"; Duration = 138; Genre = Comedy; FilmDirector = findDirectorByName "Adam McKay"; IMDbScore = 7.2; Year = 2022}
    {Title = "Drive My Car"; Duration = 179; Genre = Drama; FilmDirector = findDirectorByName "Ryusuke Hamaguchi"; IMDbScore = 7.6; Year = 2023}
    {Title = "Dune"; Duration = 155; Genre = Fantasy; FilmDirector = findDirectorByName "Denis Villeneuve"; IMDbScore = 8.1; Year = 2022}
    {Title = "King Richard"; Duration = 144; Genre = Sport; FilmDirector = findDirectorByName "Reinaldo Marcus Green"; IMDbScore = 7.5; Year = 2023}
    {Title = "Licorice Pizza"; Duration = 133; Genre = Comedy; FilmDirector = findDirectorByName "Paul Thomas Anderson"; IMDbScore = 7.4; Year = 2022}
    {Title = "Nightmare Alley"; Duration = 150; Genre = Thriller; FilmDirector = findDirectorByName "Guillermo Del Toro"; IMDbScore = 7.1; Year = 2023}
]
let potentialWinners =
    moviesData
    |> List.filter (fun movie -> movie.IMDBScore > 7.4)
