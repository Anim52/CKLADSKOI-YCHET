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
    /// Логика взаимодействия для PageProductsWrite.xaml
    /// </summary>
    public partial class PageProductsWrite : Page
    {
        public Frame MainFrame { get; set; }
        public Product Data { get; set; }
        public PageProductsWrite(Frame mainFrame, Product data)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            Data = data;

            if (data != null)
            {
                Name.Text = data.Name;
                MaterialId.Text = data.MaterialId.ToString();
                Articul.Text = data.Articul.ToString();
                MinPrice.Text = data.MinPrice.ToString();
                ImagePath.Content = data.ImagePath;
                PeopleMake.Text = data.PeopleMake.ToString();
                ManafacturAdrres.Text = data.ManafacturAdrres;
            }
        }

        private void Redict()
        {
            MainFrame.Navigate(new PageProducts(MainFrame));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Redict();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Data == null)
            {
                Data = new Product();
            }

            int MaterialIdValue = 0;
            long ArticulValue = 0;
            decimal MinPriceValue = 0;
            int PeopleMakeValue = 0;

            int.TryParse(MaterialId.Text, out MaterialIdValue);
            long.TryParse(Articul.Text, out ArticulValue);
            decimal.TryParse(MinPrice.Text, out MinPriceValue);
            int.TryParse(PeopleMake.Text, out PeopleMakeValue);

            Data.Name = Name.Text;
            Data.MaterialId = MaterialIdValue;
            Data.Articul = ArticulValue;
            Data.MinPrice = MinPriceValue;
            Data.ImagePath = ImagePath.Content.ToString();
            Data.PeopleMake = PeopleMakeValue;
            Data.ManafacturAdrres = ManafacturAdrres.Text;

            if (!ViewModelBase.IsFindMaterial(new Material { Id = MaterialIdValue }))
            {
                MessageBox.Show("Ошибка валидации формы", "");
                return;
            }

            ViewModelBase.ToogleProduct(Data);
            Redict();
        }

        private void ImagePath_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                ImagePath.Content = filename;
            }
        }
    }
}
