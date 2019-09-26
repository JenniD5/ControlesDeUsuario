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
                    lbresultado.Text = "";
                    break;

                case 1:
                    gridDeFiguras.Children.Add(new Parametrostriangulo());
                    lbresultado.Text = "";
                    break;

                case 2:
                    gridDeFiguras.Children.Add(new ParametrosRectangulo());
                    lbresultado.Text = "";
                    break;
                case 3:
                    gridDeFiguras.Children.Add(new ParametrosTrapecio());
                    lbresultado.Text = "";
                    break;
                case 4:
                    gridDeFiguras.Children.Add(new ParametrosCuadrado());
                    lbresultado.Text = "";
                    break;
                case 5:
                    gridDeFiguras.Children.Add(new ParametrosPentagono());
                    lbresultado.Text = "";
                    break;
                default:
                    break;
            }
        }

        private void BtnCalcularArea_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch(cbFigura.SelectedIndex)
            {
                case 0://circulo  //casting cuando tomamos un elemento que es un tipo de dato y la tranformamos a otro 

                    double radio = double.Parse(                                     //llamando al parametro par ausarlo en le boton, y pasadno el .txt a double
                    ((ParametrosCirulo)(gridDeFiguras.Children[0])).txtRadio.Text);
                    area = Math.PI * (radio * radio);
                    break;


                case 1:
                    double bases = double.Parse(((Parametrostriangulo)(gridDeFiguras.Children[0])).txtbase.Text);
                    double alturas = double.Parse(((Parametrostriangulo)(gridDeFiguras.Children[0])).txtaltura.Text);
                    area = (bases * alturas)/2;
                    break;

                case 2:
                    double baserec = double.Parse(((ParametrosRectangulo)(gridDeFiguras.Children[0])).txtaltura.Text);
                    double alturarect = double.Parse(((ParametrosRectangulo)(gridDeFiguras.Children[0])).txtaltura.Text);
                    area = baserec * alturarect;
                    break;

                case 3:
                    double basetra = double.Parse(((ParametrosTrapecio)(gridDeFiguras.Children[0])).txtbasemayor.Text);
                    double basemenor = double.Parse(((ParametrosTrapecio)(gridDeFiguras.Children[0])).txtbasemenor.Text);
                    double alturatra = double.Parse(((ParametrosTrapecio)(gridDeFiguras.Children[0])).txtaluta.Text);
                    area = ((basetra + basemenor) * alturatra) / 2;

                    break;

                case 4:
                    double lado = double.Parse(((ParametrosCuadrado)(gridDeFiguras.Children[0])).txtlado.Text);
                    area = lado * lado;
                    break;
 
               case 5:
                    double perimetro = double.Parse(((ParametrosPentagono)(gridDeFiguras.Children[0])).txtperimetro.Text);
                    double apotema = double.Parse(((ParametrosPentagono)(gridDeFiguras.Children[0])).txtapotema.Text);
                    area = (perimetro * apotema) / 2;
                    break;
                default:
                    break;

            }

            lbresultado.Text = area.ToString();
        }

      
    }
}
