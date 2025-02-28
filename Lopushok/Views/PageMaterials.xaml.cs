using Lopushok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Lopushok.Models;
using Lopushok.ViewModels;

namespace Lopushok.Views
{
    /// <summary>
    /// Логика взаимодействия для PageMaterials.xaml
    /// </summary>
    public partial class PageMaterials : Page
    {
        public Frame MainFrame { get; set; }
        public PageMaterials(Frame mainFrame)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            DataGrid.ItemsSource = ViewModelBase.GetMaterial();
        }

        private Material CheckRow()
        {
            Material? Item = DataGrid.SelectedItem as Material;

            return ViewModelBase.IsFindMaterial(Item) != null ? Item : null;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageMaterialsWrite(MainFrame, null));
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var Row = CheckRow();

            if (Row != null)
            {
                MainFrame.Navigate(new PageMaterialsWrite(MainFrame, Row));
            }
        }

        private void Delet_Click(object sender, RoutedEventArgs e)
        {
            var Row = CheckRow();

            if (Row != null)
            {
                ViewModelBase.DeletMaterial(Row);
                MainFrame.Navigate(new PageMaterials(MainFrame));
            }
        }
    }
}
