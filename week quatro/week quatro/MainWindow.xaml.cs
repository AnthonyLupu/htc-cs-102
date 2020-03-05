using System;
using System.Collections.Generic;
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

namespace week_quatro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private List<movie> Movies;
        public MainWindow()
        {
            InitializeComponent();
            Movies = new List<movie>();
        }

        private void addbut(object sender, RoutedEventArgs e)
        {
            movie movie = new movie(Titleinput.Text, Convert.ToInt32(Ryearinput.Text));
            Movies.Add(movie);
            Titleinput.Clear();
            Ryearinput.Clear();
        }

        private void showbut(object sender, RoutedEventArgs e)
        {
            foreach (movie movie in Movies)
            {
                movie.Showd();
            }
        }
    }
}
