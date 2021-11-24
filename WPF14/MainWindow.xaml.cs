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
using WPF14;

namespace WPF14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> product;
        public MainWindow()
        {
            InitializeComponent();

            product = new ObservableCollection<Product>();
            product.Add(new Product()
            {
                Name = "Coca-Cola",
                Price = 10,
                Image = "Data/Coca-cola.png",
                Category = ProductTypes.Food
            });

            listBox.ItemsSource = product;
        }
    }
}
