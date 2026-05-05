using System.Xml.Linq;

namespace project01
{
    internal class Program
    {
        //Movie Class:
        class Movie
        {
            public string Title { get; set; }
            public string Genre { get; set; }

            private int rating;

            public int Rating
            {
                get { return rating; }
                set
                {
                    if (value >= 1 && value <= 10)
                        rating = value;
                    else
                        Console.WriteLine("Rating must be between 1 and 10");
                }
            }

            public Movie(string title, string genre, int rating)
            {
                Title = title;
                Genre = genre;
                Rating = rating;
            }
        }

        //User Class:

        class User
        {
            public string Name { get; set; }

            private int watchCount;

            public int WatchCount
            {
                get { return watchCount; }
            }

            public User(string name)
            {
                Name = name;
                watchCount = 0;
            }

            // WatchSession Method:

            public void WatchMovie(Movie movie)
            {
                watchCount++;
                Console.WriteLine($"{Name} is watching {movie.Title}");
            }

            //RateMovie Method:

            public void RateMovie(Movie movie, int rate)
            {
                if (rate >= 1 && rate <= 10)
                {
                    movie.Rating = rate;
                    Console.WriteLine($"{Name} rated {movie.Title} with {rate}");
                }
                else
                {
                    Console.WriteLine("Invalid rating!");
                }
            }

            //WatchSession Class:

            class WatchSession
            {
                public string UserName { get; set; }
                public string MovieTitle { get; set; }

                public WatchSession(string userName, string movieTitle)
                {
                    UserName = userName;
                    MovieTitle = movieTitle;
                }
            }
        }




        static void Main(string[] args)
        {            
                Movie m1 = new Movie("Inception", "Sci-Fi", 9);
                User u1 = new User("Malak");

                u1.WatchMovie(m1);
                u1.RateMovie(m1, 10);

                Console.ReadLine();
            
        }
    }
}
