using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bochagova_ExamHotelContext context = new Bochagova_ExamHotelContext(); 
        public MainWindow()
        {
            InitializeComponent();
            LoadClient();
        }

        public void LoadClient()
        {
            //Выборка клиентов, которые ещё находятся в гостинице
            var clients = context.Contract.Include(a => a.IdClientNavigation).Where(a => a.DateOut >= DateTime.Now).ToList();
            listClient.Items.Clear();
            listClient.ItemsSource = clients;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEditClientWindow addWindow = new AddEditClientWindow();
            Close();
            addWindow.ShowDialog();            
        }
    }
}
