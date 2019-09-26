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

namespace Control_De_Usuario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridDeFiguras.Children.Clear();//para limpiar todo los elementos a un arreglo o coleccion
                //children es un collecccion de la clase en la cual se basan todos los controles de usuario, son todos los elementos que tiene 
                //cada cambio de seleccion se le borra todo lo que quedo del calculo restante 
            switch(cbFigura.SelectedIndex)
            {
                case 0://para el cirulo 
                    gridDeFiguras.Children.Add( new ParametrosCirulo ());
                    break;

                case 1:
                    gridDeFiguras.Children.Add(new Parametrostriangulo());
                    break;

                case 2:
                    gridDeFiguras.Children.Add(new ParametrosRectangulo());
                    break;
                case 3:
                    gridDeFiguras.Children.Add(new ParametrosTrapecio());
                    break;
                case 4:
                    gridDeFiguras.Children.Add(new ParametrosCuadrado());
                    break;
                case 5:
                    gridDeFiguras.Children.Add(new ParametrosPentagono());
                    break;
                default:
                    break;
            }
        }

        private void BtnCalcularArea_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
