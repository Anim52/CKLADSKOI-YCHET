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
    /// Логика взаимодействия для PageWarehousesWrite.xaml
    /// </summary>
    public partial class PageWarehousesWrite : Page
    {
        public Frame MainFrame { get; set; }
        public Warehouse Data { get; set; }
        public PageWarehousesWrite(Frame mainFrame, Warehouse data)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            Data = data;

            if (data != null)
            {
                Name.Text = data.Name;
                Adress.Text = data.Adress;
            }
        }


        private void Redict()
        {
            MainFrame.Navigate(new PageWarehouses(MainFrame));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Redict();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Data == null)
            {
                Data = new Warehouse();
            }

            Data.Name = Name.Text;
            Data.Adress = Adress.Text;

            ViewModelBase.ToogleWarehouse(Data);
            Redict();
        }
    }
}
