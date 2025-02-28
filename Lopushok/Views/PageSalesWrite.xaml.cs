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
    /// Логика взаимодействия для PageSalesWrite.xaml
    /// </summary>
    public partial class PageSalesWrite : Page
    {
        public Frame MainFrame { get; set; }
        public Sales Data { get; set; }
        public PageSalesWrite(Frame mainFrame, Sales data)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            Data = data;

            if (data != null)
            {
                AgentId.Text = data.AgentId.ToString();
                WarehouseProductId.Text = data.WarehouseProductId.ToString();
                SalesCount.Text = data.SalesCount.ToString();
                SalesDate.Text = data.SalesDate;
            }
        }

        private void Redict()
        {
            MainFrame.Navigate(new PageSales(MainFrame));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Redict();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Data == null)
            {
                Data = new Sales();
            }

            int AgentIdValue = 0;
            int WarehouseProductIdValue = 0;
            int SalesCountValue = 0;

            int.TryParse(AgentId.Text, out AgentIdValue);
            int.TryParse(WarehouseProductId.Text, out WarehouseProductIdValue);
            int.TryParse(SalesCount.Text, out SalesCountValue);

            Data.AgentId = AgentIdValue;
            Data.WarehouseProductId = WarehouseProductIdValue;
            Data.SalesCount = SalesCountValue;
            Data.SalesDate = "Не выбрана";
            DateTime? CurrentDate = SalesDate.SelectedDate;

            if (CurrentDate != null)
            {
                Data.SalesDate = CurrentDate.Value.ToShortDateString();
            }


            if (!ViewModelBase.IsFindAgent(new Agent { Id = AgentIdValue }) ||
                !ViewModelBase.IsFindWarehouseProduct(new WarehouseProduct { Id = WarehouseProductIdValue }))
            {
                MessageBox.Show("Ошибка валидации формы", "");
                return;
            }

            ViewModelBase.ToogleSales(Data);
            Redict();
        }
    }
}
