using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product produit = new Product();
            int id;
            if (int.TryParse(txbID.Text, out id))
            {
                if (App.dicProduit.TryGetValue(id, out produit))
                {
                    MessageBox.Show(produit.ToString());
                }
                else
                {
                    MessageBox.Show($"Product {txbID.Text} does not exist!");
                }
            }
            else
            {
                MessageBox.Show("Not a valide ID");
            }

           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Pas de produit valid pour l'id 127
            App.dicProduit[114].Price = 59.99;
            App.dicProduit[74].Name = "Halo 4";
            App.dicProduit[1027].Stock = 0;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            string ids = string.Join(", ", App.dicProduit.Keys);
            MessageBox.Show($"Inventory contains {App.dicProduit.Count} diffente product with following ids {ids}");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var kvp in App.dicProduit)
            {
                Product p = kvp.Value;
                sb.AppendLine($"{p.Id} - {p.Stock}");
            }

            MessageBox.Show(sb.ToString(), "Inventory");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            App.dicProduit.Add(2111, new Product() { Id = 2111, Name = "Baldur's Gate 3", Price = 79.99, Stock = 25 });
            App.dicProduit2.Add("Baldur's Gate 3", new Product() { Id = 2111, Name = "Baldur's Gate 3", Price = 79.99, Stock = 25 });
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            App.dicProduit.Remove(App.dicProduit2["Starfield"].Id);
            App.dicProduit2.Remove("Starfield");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var kvp in App.dicProduit2)
            {
                if(kvp.Key == "Starfield" || kvp.Key == "Diablo 4")
                {
                    Product p = kvp.Value;
                    sb.AppendLine(p.ToString());
                }
            }


            MessageBox.Show(sb.ToString(), "Info sur les produit");
        }
    }
}