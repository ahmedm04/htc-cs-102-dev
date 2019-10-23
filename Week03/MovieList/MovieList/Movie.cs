using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string rtScore { get; set; }

        public Movie(string title, int releaseyear, string RTScore)
        {
            Title = title;
            ReleaseYear = releaseyear;
            rtScore = RTScore;

        }

        public void ShowDetails()
        {
            MessageBox.Show(Title + " was released in " + ReleaseYear);
        }

    }
}
