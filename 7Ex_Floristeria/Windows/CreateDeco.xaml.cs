using _7Ex_Floristeria.Models;
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
using System.Windows.Shapes;

namespace _7Ex_Floristeria
{
    /// <summary>
    /// Lógica de interacción para CreateDeco.xaml
    /// </summary>
    public partial class CreateDeco : Window
    {
        public static string myValue = String.Empty;
        public static double myPrice = 0;
        public static int myMaterial;
        public CreateDeco()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            myValue = Name.Text;
            myPrice = Convert.ToDouble(Price.Text);
            if (Wood.IsChecked==true) myMaterial = 0; 
            if (Plastic.IsChecked == true) myMaterial = 1;
            this.Close();
        }
    }
}
