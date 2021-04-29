using MarketWpf.Models;
using System;
using System.Collections;
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

namespace MarketWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>()
        {
            new Product
            {
                Id=1,
                Name="Cola",
                Category="Cold Drinks",
                UnitPrice=1,
                StockAmount=100,
                ImagePath="cola.jpg"

            },
            new Product
            {
                Id=2,
                Name="Lays",
                Category="Snack",
                UnitPrice=2.30,
                StockAmount=90,
                 ImagePath="lays.jpg"
            },
            new Product
            {
                Id=3,
                Name="Nesquik",
                Category="Breakfast",
                UnitPrice=3,
                StockAmount=50,
                ImagePath="nesquik.jpg"
            },
            new Product
            {
                Id=4,
                Name="Apple",
                Category="Fruit",
                UnitPrice=1.5,
                StockAmount=10,
                ImagePath="alma.jpg"
            },
             new Product
             {
                Id=5,
                Name="Bisquick",
                Category="Cookies",
                UnitPrice=0.8,
                StockAmount=200,
                ImagePath="tutku.jpg"
             },
              new Product
              {
                Id=6,
                Name="Spagetti",
                Category="Pasta",
                UnitPrice=1,
                StockAmount=100,
                ImagePath="spageti.jpg"
              },

        };
        public MainWindow()
        {
            InitializeComponent();
            listbox.ItemsSource = Products;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (listbox.SelectedItem is null)
            {
                MessageBox.Show("You dont select anything");
                return;
            }

            var edit = new EditWindow();
            edit.EditPro = listbox.SelectedItem as Product;
            edit.ShowDialog();

        }

        private void SearhTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (SearhTxt.Text != string.Empty)
            {
                ObservableCollection<Product> pro = new ObservableCollection<Product>();
                pro = GetProductsByName(SearhTxt.Text);
                listbox.ItemsSource = null;
                listbox.ItemsSource = pro;
            }
            else
            {
                listbox.ItemsSource = null;
                listbox.ItemsSource = Products;
            }
        }


        private ObservableCollection<Product> GetProductsByName(string s)
        {
            var item = Products
                .Where(n => n.Name.Contains(s)).ToList();


            ObservableCollection<Product> mylist = new ObservableCollection<Product>(item);
            return mylist;
        }
    }
}
