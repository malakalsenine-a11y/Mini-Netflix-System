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
        }




        static void Main(string[] args)
        {
        }
    }
}
