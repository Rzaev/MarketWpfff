using MarketWpf.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace MarketWpf
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window, INotifyPropertyChanged
    {
        public EditWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }


        private Product editPro;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public Product EditPro
        {
            get { return editPro; }
            set { editPro = value;OnPropertyChanged(); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if(openFileDialog.ShowDialog()==true)
            {
                var filepath = openFileDialog.FileName;
                MyImage.Text = filepath;
                //Image image = new Image();
                //image.HorizontalAlignment = HorizontalAlignment.Center;
                //image.VerticalAlignment = VerticalAlignment.Center;
                //image.Source = new BitmapImage(new Uri(filepath));
            }
        }
    }
}
