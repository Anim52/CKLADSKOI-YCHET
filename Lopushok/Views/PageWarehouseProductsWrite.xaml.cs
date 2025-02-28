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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lopushok.Views
{
    /// <summary>
    /// Логика взаимодействия для PageWarehouseProductsWrite.xaml
    /// </summary>
    public partial class PageWarehouseProductsWrite : Page
    {
        public Frame MainFrame { get; set; }
        public WarehouseProduct Data { get; set; }
        public PageWarehouseProductsWrite(Frame mainFrame, WarehouseProduct data)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            Data = data;

            if (data != null)
            {
                WarehouseId.Text = data.WarehouseId.ToString();
                ProductId.Text = data.ProductId.ToString();
                CountProduct.Text = data.CountProduct.ToString();
            }
        }

        private void Redict()
        {
            MainFrame.Navigate(new PageWarehouseProducts(MainFrame));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Redict();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Data == null)
            {
                Data = new WarehouseProduct();
            }

            int WarehouseIdValue = 0;
            int ProductIdValue = 0;
            long CountProductValue = 0;

            int.TryParse(WarehouseId.Text, out WarehouseIdValue);
            int.TryParse(ProductId.Text, out ProductIdValue);
            long.TryParse(CountProduct.Text, out CountProductValue);

            Data.WarehouseId = WarehouseIdValue;
            Data.ProductId = ProductIdValue;
            Data.CountProduct = CountProductValue;

            if (!ViewModelBase.IsFindWarehouse(new Warehouse { Id = WarehouseIdValue }) ||
                !ViewModelBase.IsFindProduct(new Product { Id = ProductIdValue }))
            {
                MessageBox.Show("Ошибка валидации формы", "");
                return;
            }

            ViewModelBase.ToogleWarehouseProduct(Data);
            Redict();
        }
    }
}
