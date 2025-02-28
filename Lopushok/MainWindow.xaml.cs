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

using Lopushok.Views;

namespace Lopushok
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Agents_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageAgents(MainFrame));
            Title = "Лопушок | Агенты";
        }

        private void Materials_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageMaterials(MainFrame));
            Title = "Лопушок | Материалы";
        }

        private void Warehouses_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageWarehouses(MainFrame));
            Title = "Лопушок | Склады";
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageProducts(MainFrame));
            Title = "Лопушок | Продукты";
        }

        private void WarehouseProducts_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageWarehouseProducts(MainFrame));
            Title = "Лопушок | Продукты на складах";
        }

        private void Sales_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageSales(MainFrame));
            Title = "Лопушок | Продажи продуктов";
        }
    }
}
