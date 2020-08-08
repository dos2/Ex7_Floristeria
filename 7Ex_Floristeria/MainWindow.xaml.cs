using _7Ex_Floristeria.Models;
using _7Ex_Floristeria.Windows;
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
        floristeria floristeria;
        public MainWindow()
        {
            InitializeComponent();
            InputFloristeria dialogBox = new InputFloristeria();
            dialogBox.ShowDialog();
            string nameFromdialogBox = InputFloristeria.myValue;
            nombreEmpresa.Content = nameFromdialogBox;

            floristeria = new floristeria(nameFromdialogBox);
            
            /*floristeria.addDecoracion("Deco1",Decoracion.Material.Plastico, 12);
            floristeria.addArbol(12, 23);
            foreach (Elements e in floristeria.Almacen)
            {
                Console.WriteLine(e.ToString());
            }*/
        }
        private void createDeco_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CreateDeco dialogBox = new CreateDeco();
            dialogBox.ShowDialog();
            string nameFromdialogBox = CreateDeco.myValue;
            double priceFromdialogBox = CreateDeco.myPrice;
            int materialFromdialogBox = CreateDeco.myMaterial;
            if (materialFromdialogBox==0) floristeria.addDecoracion(nameFromdialogBox ,Decoracion.Material.Plastico, priceFromdialogBox);
            else floristeria.addDecoracion(nameFromdialogBox, Decoracion.Material.Madera, priceFromdialogBox);
            Console.WriteLine("Creado {0} de {2} y con un precio de {1}",nameFromdialogBox,priceFromdialogBox,materialFromdialogBox);
        }
        private void viewStock_MouseDown(object sender, MouseEventArgs e)
        {
            List<Elements> Almacen = new List<Elements>();
            Almacen = floristeria.getStock();
            ViewStock dialogBox = new ViewStock();
            foreach (Elements el in Almacen)
            {
                if (el.Type==2) dialogBox.itemDecoracion.Items.Add(el.ToString());
            }
            dialogBox.ShowDialog();
        }
    }
}
