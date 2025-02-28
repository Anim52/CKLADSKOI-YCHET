using Lopushok.Models;
using Lopushok.ViewModels;
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

namespace Lopushok.Views
{
    /// <summary>
    /// Логика взаимодействия для PageProducts.xaml
    /// </summary>
    public partial class PageProducts : Page
    {
        public Frame MainFrame { get; set; }
        public PageProducts(Frame mainFrame)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            DataGrid.ItemsSource = ViewModelBase.GetProduct();
        }


        private Product CheckRow()
        {
            Product? Item = DataGrid.SelectedItem as Product;

            return ViewModelBase.IsFindProduct(Item) != null ? Item : null;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageProductsWrite(MainFrame, null));
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var Row = CheckRow();

            if (Row != null)
            {
                MainFrame.Navigate(new PageProductsWrite(MainFrame, Row));
            }
        }

        private void Delet_Click(object sender, RoutedEventArgs e)
        {
            var Row = CheckRow();

            if (Row != null)
            {
                ViewModelBase.DeletProduct(Row);
                MainFrame.Navigate(new PageProducts(MainFrame));
            }
        }
    }
}
