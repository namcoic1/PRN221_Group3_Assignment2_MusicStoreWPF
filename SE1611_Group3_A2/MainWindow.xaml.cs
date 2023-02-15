using SE1611_Group3_A2.Controller;
using SE1611_Group3_A2.Models;
using SE1611_Group3_A2.ResourceXAML;
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

namespace SE1611_Group3_A2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginWindow loginWindow;
        private CartController controller = new CartController();
        public bool accessed = false;

        public MainWindow()
        {
            InitializeComponent();
            viewAllCarts();
        }

        private void viewAllCarts()
        {
            int size = controller.getAllCarts().Count;
            btnCart.Content = $"Cart ({size})";
        }
        public void setAccessed(string role)
        {
            if (accessed)
            {
                btnLogin.Content = $"Logout ({role})";
                btnAlbum.IsEnabled = role.Equals("admin")? true : btnAlbum.IsEnabled;
            }
        }

        private void btnShopping_Click(object sender, RoutedEventArgs e)
        {
            ShoppingWindow shoppingWindow = new ShoppingWindow();
            shoppingWindow.Show();
        }

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {
            if (accessed)
            {
                CartWindow cartWindow = new CartWindow();
                cartWindow.Show();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!accessed)
            {
                loginWindow = new LoginWindow(this);
                loginWindow.Show();
            }
            else
            {
                btnLogin.Content = "Login";
                btnAlbum.IsEnabled = false;
                new MainWindow().Show();
                this.Close();
            }
        }

        private void btnAlbum_Click(object sender, RoutedEventArgs e)
        {
            AlbumWindow albumWindow = new AlbumWindow();
            albumWindow.Show();
        }
    }
}
