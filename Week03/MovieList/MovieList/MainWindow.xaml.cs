using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Movie> movies = new ObservableCollection<Movie>();

        public MainWindow()
        {
            InitializeComponent();
            lvMovies.ItemsSource = movies;
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in movies)
            {
                MessageBox.Show("The movie is " + movie.Title + "\r\n" + " The movie was released in " + movie.ReleaseYear);
            }

        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = titleInput.Text;
            int releaseYear = Convert.ToInt32(releaseYearInput.Text);
            string rtScore = rtInput.Text;

            Movie movie = new Movie(title, releaseYear, rtScore);
            movies.Add(movie);
            MessageBox.Show("Movie was added!");
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
            }
        }
    }
}
