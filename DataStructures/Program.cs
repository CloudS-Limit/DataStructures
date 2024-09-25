namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie deadpool3;
            deadpool3.title = "deadpool and wolverine";
            deadpool3.releaseYear = 2024;
            deadpool3.price = 19.99;
            deadpool3.rating = MovieRating._15;

            Console.WriteLine(deadpool3.title + "(" + deadpool3.releaseYear + ") Rated " + deadpool3.rating);

            Console.ReadKey();
            Console.WriteLine("\n\n");
            Console.Clear();

            List<TVShow> shows = new List <TVShow>();  
            shows.Add(new TVShow("The Lord of the Rings: The Rings Of Power", 2022, 0, MovieRating._15));
            shows.Add(new TVShow("the boys", 2019, 7.99, MovieRating._18));

            for (int i = 0; i < shows.Count; i++)
            {
                Console.WriteLine(shows[i].ToString());
            }
            Console.ReadKey();
        }

        public enum MovieRating 
        {
            _U,
            _12A,
            _12,
            _15,
            _18
            
        }

        public struct Movie
        {
            public string title;
            public int releaseYear;
            public double price;
            public MovieRating rating;
        }
    }
}
