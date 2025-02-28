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

using Lopushok.Models;
using Lopushok.ViewModels;

namespace Lopushok.Views
{
    /// <summary>
    /// Логика взаимодействия для PageMaterialsWrite.xaml
    /// </summary>
    public partial class PageMaterialsWrite : Page
    {
        public Frame MainFrame { get; set; }
        public Material Data { get; set; }

        public PageMaterialsWrite(Frame mainFrame, Material data)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            Data = data;

            if (data != null)
            {
                Name.Text = data.Name;
                CountMaterials.Text = data.CountMaterials;
                TypeMaterial.Text = data.TypeMaterial;
            }
        }

        private void Redict()
        {
            MainFrame.Navigate(new PageMaterials(MainFrame));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Redict();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Data == null)
            {
                Data = new Material();
            }

            Data.Name = Name.Text;
            Data.CountMaterials = CountMaterials.Text;
            Data.TypeMaterial = TypeMaterial.Text;

            ViewModelBase.ToogleMaterial(Data);
            Redict();
        }
    }
}
