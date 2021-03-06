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
using System.Collections.ObjectModel;

namespace Wpf_lab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>
                {
                    new Product { Name = "Сыр", Price = 999, Image = @"Data\cheese.png", Type = ProductTypes.Food },
                    new Product { Name = "Хлеб", Price = 99, Image = @"Data\bread.png", Type = ProductTypes.Food },
                    new Product { Name = "Микроволновая печь", Price = 9999, Image = @"Data\microwave.png", Type = ProductTypes.Technics },
                    new Product { Name = "Холодильник", Price = 99999, Image = @"Data\fridge.png", Type = ProductTypes.Technics }
                };

            listBox.ItemsSource = products;
        }
    }

}
