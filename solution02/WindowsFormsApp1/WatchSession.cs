using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniNetflix
{
    class WatchSession
    {
        public string UserName { get; }
        public string MovieTitle { get; }

        public WatchSession(string userName, string movieTitle)
        {
            UserName = userName;
            MovieTitle = movieTitle;
        }
    }
}