using modul6_1302213089;

SayaTubeUser user = new SayaTubeUser("Vikhan");

String[] movie = new string[]
{
    "AADC",
    "OTTO",
    "Superman",
    "Batman",
    "Toy Story",
    "Habibie Ainun",
    "Tenggelamnya kapal Van Der Wijk",
    "Upin ipin",
    "Doraemon",
    "Naruto"
};

for (int i = 0;i < movie.Length; i++)
{
    SayaTubeVideo film = new SayaTubeVideo("Review Film "+movie[i]+" oleh Muhammad Vikhan Muharram");
    film.IncreasePlayCount(100);
    Console.WriteLine("\nMenambahkan Film : ");
    film.printVideoDetails();
    user.AddVideo(film);
}
Console.WriteLine("\n");
user.PrintAllVideoPlayCount();
Console.WriteLine("Jumlah playCount semua film adalah : " + user.GetTotalVideoPlayCount());
