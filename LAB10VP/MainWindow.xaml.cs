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

namespace LAB10VP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        employees emp = new employees { FirstName ="Muhammad" ,LastName="omer",Gender="male",Contact="123",ADD ="ATTOCK",WarehouseNo="123",WarehouseName="Pakistan" };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = emp;
        }
        employees omer1;
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = Brushes.Green;
            this.Resources["brushResource"]= brush;
        }
    }
}
