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
    /// Логика взаимодействия для PageAgentsWrite.xaml
    /// </summary>
    public partial class PageAgentsWrite : Page
    {
        public Frame MainFrame { get; set; }
        public Agent Data { get; set; }
        public PageAgentsWrite(Frame mainFrame, Agent data)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            Data = data;

            if (data != null)
            {
                Name.Text = data.Name;
                INN.Text = data.INN.ToString();
                LegalAdress.Text = data.LegalAdress;
                Directro.Text = data.Directro;
            }
        }


        private void Redict()
        {
            MainFrame.Navigate(new PageAgents(MainFrame));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Redict();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Data == null)
            {
                Data = new Agent();
            }

            int INNValue = 0;

            int.TryParse(INN.Text, out INNValue);

            Data.Name = Name.Text;
            Data.INN = INNValue;
            Data.LegalAdress = LegalAdress.Text;
            Data.Directro = Directro.Text;

            ViewModelBase.ToogleAgent(Data);
            Redict();
        }

    }
}
