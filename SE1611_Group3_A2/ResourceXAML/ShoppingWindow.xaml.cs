using SE1611_Group3_A2.Controller;
using SE1611_Group3_A2.Models;
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
using System.Windows.Shapes;

namespace SE1611_Group3_A2.ResourceXAML
{
    /// <summary>
    /// Interaction logic for ShoppingWindow.xaml
    /// </summary>
    public partial class ShoppingWindow : Window
    {
        AlbumController albumController = new AlbumController();
        GenreController genreController = new GenreController();
        CartController cartController = new CartController();

        public ShoppingWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cbGenre.Items.Clear();
            cbGenre.ItemsSource = genreController.getAllGenre();
            cbGenre.DisplayMemberPath = "Name";
            cbGenre.SelectedValuePath = "GenreId";

            //load albums
            List<Album> albums = albumController.getAlbumsByLimitOffet(0, 0);
            viewAlbums(albums);
            lbPage.Content = 0;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (cbGenre.Text.Length == 0)
            {
                try
                {
                    int countAlbums = albumController.getAllAlbums().Count();
                    List<Album> albums = albumController.getAlbumsByLimitOffet(int.Parse(lbPage.Content.ToString()), 0);
                    viewAlbums(albums);
                    MessageBox.Show("Found " + countAlbums + " results!", "Search");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }

            }
            else
            {
                try
                {
                    int genreIdSelected = int.Parse(cbGenre.SelectedValue.ToString());
                    int countAlbums = albumController.getAlbumsByGenreId(genreIdSelected).Count();
                    List<Album> albums = albumController.getAlbumsByLimitOffet(int.Parse(lbPage.Content.ToString()), genreIdSelected);
                    viewAlbums(albums);
                    MessageBox.Show("Found " + countAlbums + " results!", "Search");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }

            }
        }

        private void viewAlbums(List<Album> albums)
        {
            int sizeAlbums = albums.Count;
            // album1
            if (sizeAlbums > 0)
            {
                try
                {
                    lbAlbum1.Visibility = Visibility.Visible;
                    imgAlbum1.Visibility = Visibility.Visible;
                    btnAlbum1.Visibility = Visibility.Visible;
                    lbAlbum1_Id.Content = albums[0].AlbumId;
                    lbAlbum1.Content = albums[0].Title + ": " + albums[0].Price + " USD";
                    imgAlbum1.Stretch = Stretch.Fill;
                    imgAlbum1.Source = new BitmapImage(new Uri(albums[0].AlbumUrl, UriKind.Relative));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
            }
            else
            {
                lbAlbum1.Visibility = Visibility.Hidden;
                imgAlbum1.Visibility = Visibility.Hidden;
                btnAlbum1.Visibility = Visibility.Hidden;
            }
            // album2
            if (sizeAlbums > 1)
            {
                try
                {
                    lbAlbum2.Visibility = Visibility.Visible;
                    imgAlbum2.Visibility = Visibility.Visible;
                    btnAlbum2.Visibility = Visibility.Visible;
                    lbAlbum2_Id.Content = albums[1].AlbumId;
                    lbAlbum2.Content = albums[1].Title + ": " + albums[1].Price + " USD";
                    imgAlbum2.Stretch = Stretch.Fill;
                    imgAlbum2.Source = new BitmapImage(new Uri(albums[1].AlbumUrl, UriKind.Relative));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
            }
            else
            {
                lbAlbum2.Visibility = Visibility.Hidden;
                imgAlbum2.Visibility = Visibility.Hidden;
                btnAlbum2.Visibility = Visibility.Hidden;
            }
            // album3
            if (sizeAlbums > 2)
            {
                try
                {
                    lbAlbum3.Visibility = Visibility.Visible;
                    imgAlbum3.Visibility = Visibility.Visible;
                    btnAlbum3.Visibility = Visibility.Visible;
                    lbAlbum3_Id.Content = albums[2].AlbumId;
                    lbAlbum3.Content = albums[2].Title + ": " + albums[2].Price + " USD";
                    imgAlbum3.Stretch = Stretch.Fill;
                    imgAlbum3.Source = new BitmapImage(new Uri(albums[2].AlbumUrl, UriKind.Relative));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Excpetion");
                }
            }
            else
            {
                lbAlbum3.Visibility = Visibility.Hidden;
                imgAlbum3.Visibility = Visibility.Hidden;
                btnAlbum3.Visibility = Visibility.Hidden;
            }
            // album4
            if (sizeAlbums > 3)
            {
                try
                {
                    lbAlbum4.Visibility = Visibility.Visible;
                    imgAlbum4.Visibility = Visibility.Visible;
                    btnAlbum4.Visibility = Visibility.Visible;
                    lbAlbum4_Id.Content = albums[3].AlbumId;
                    lbAlbum4.Content = albums[3].Title + ": " + albums[3].Price + " USD";
                    imgAlbum4.Stretch = Stretch.Fill;
                    imgAlbum4.Source = new BitmapImage(new Uri(albums[3].AlbumUrl, UriKind.Relative));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                }
            }
            else
            {
                lbAlbum4.Visibility = Visibility.Hidden;
                imgAlbum4.Visibility = Visibility.Hidden;
                btnAlbum4.Visibility = Visibility.Hidden;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int nextPage = int.Parse(lbPage.Content.ToString()) + 1;
                int genreIdSelected;
                if (cbGenre.Text.Length == 0) genreIdSelected = 0;
                else genreIdSelected = int.Parse(cbGenre.SelectedValue.ToString());

                List<Album> albums = albumController.getAlbumsByLimitOffet(nextPage, genreIdSelected);
                if (albums.Count == 0)
                {
                    MessageBox.Show("Out of stock!", "Next");
                }
                else
                {
                    viewAlbums(albums);
                    lbPage.Content = int.Parse(lbPage.Content.ToString()) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void cbGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbPage.Content = 0;
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(lbPage.Content.ToString()) == 0)
                {
                    MessageBox.Show("These are the first albums in stock!", "Previous");
                    return;
                }
                else
                {
                    int nextPage = int.Parse(lbPage.Content.ToString()) - 1;
                    int genreIdSelected;
                    if (cbGenre.Text.Length == 0) genreIdSelected = 0;
                    else genreIdSelected = int.Parse(cbGenre.SelectedValue.ToString());

                    List<Album> albums = albumController.getAlbumsByLimitOffet(nextPage, genreIdSelected);
                    viewAlbums(albums);
                    lbPage.Content = int.Parse(lbPage.Content.ToString()) - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void btnAlbum1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime today = DateTime.UtcNow.Date;
                int album1_Id = int.Parse(lbAlbum1_Id.Content.ToString());
                cartController.addCart(new Cart("user", album1_Id,1,today));
                MessageBox.Show("Add to cart successfully!", "Add to cart");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void btnAlbum2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime today = DateTime.UtcNow.Date;
                int album2_Id = int.Parse(lbAlbum2_Id.Content.ToString());
                cartController.addCart(new Cart("user", album2_Id, 1, today));
                MessageBox.Show("Add to cart successfully!", "Add to cart");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void btnAlbum3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime today = DateTime.UtcNow.Date;
                int album3_Id = int.Parse(lbAlbum3_Id.Content.ToString());
                cartController.addCart(new Cart("user", album3_Id, 1, today));
                MessageBox.Show("Add to cart successfully!", "Add to cart");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void btnAlbum4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime today = DateTime.UtcNow.Date;
                int album4_Id = int.Parse(lbAlbum4_Id.Content.ToString());
                cartController.addCart(new Cart("user", album4_Id, 1, today));
                MessageBox.Show("Add to cart successfully!", "Add to cart");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            // link to Cart_Window
        }
    }
}
