using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static public Dictionary<int,Product> dicProduit = new Dictionary<int, Product>() {
            {114, new Product(){Id = 144, Name = "Diablo 4", Price = 49.99, Stock = 8} },
            {74, new Product(){Id = 74, Name = "Halo 3", Price = 49.99, Stock = 3} },
            {1027, new Product(){Id = 1027, Name = "Starfield", Price = 49.99, Stock = 11} }
        };


        static public Dictionary<string, Product> dicProduit2 = new Dictionary<string, Product>() {
            {"Diablo 4", new Product(){Id = 144, Name = "Diablo 4", Price = 49.99, Stock = 8} },
            {"Halo 3", new Product(){Id = 74, Name = "Halo 3", Price = 49.99, Stock = 3} },
            {"Starfield", new Product(){Id = 1027, Name = "Starfield", Price = 49.99, Stock = 11} }
        };
    }

}
