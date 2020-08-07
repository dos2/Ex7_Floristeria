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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _7Ex_Floristeria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InputFloristeria dialogBox = new InputFloristeria();
            dialogBox.ShowDialog();
            string nameFromdialogBox = InputFloristeria.myValue;
            nombreEmpresa.Content = nameFromdialogBox;

            floristeria floristeria = new floristeria(nameFromdialogBox);
            
            floristeria.addDecoracion(Decoracion.Material.Plastico, 12);
            floristeria.addArbol(12, 23);
            foreach (Elements e in floristeria.Almacen)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CreateDeco dialogBox = new CreateDeco();
            dialogBox.ShowDialog();
            string nameFromdialogBox = CreateDeco.myValue;
            double priceFromdialogBox = CreateDeco.myPrice;
            int materialFromdialogBox = CreateDeco.myMaterial;
            Console.WriteLine("{0}{1}{2}",nameFromdialogBox,priceFromdialogBox,materialFromdialogBox);
        }
    }
}
