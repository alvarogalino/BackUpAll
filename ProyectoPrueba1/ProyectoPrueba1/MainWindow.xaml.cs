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

namespace ProyectoPrueba1
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

        private void btbLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtAConst.Clear();
            txtAgua.Clear();
            txtAlquiler.Clear();
            txtGas.Clear();
            txtLuz.Clear();
            txtDireccion.Clear();
            txtAConst.Clear();
            txtAmbientes.Clear();

            

            

            

        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            Vivienda viviendaNueva = new Vivienda();
            viviendaNueva.Direccion = txtAConst.Text;
            viviendaNueva.Amb = float.Parse(txtAmbientes.Text);
            viviendaNueva.Agua=txtAgua.Text;
            viviendaNueva.Luz = txtLuz.Text;
            viviendaNueva.Gas = txtGas.Text;
            viviendaNueva.Alquiler=float.Parse(txtAlquiler.Text);
            viviendaNueva.AContruccion=float.Parse(txtAConst.Text);

            float totalGastos= viviendaNueva.CalcularGastosExtras()+viviendaNueva.CalcularExpensas()+viviendaNueva.Alquiler;

            blqVivTipo.Text = viviendaNueva.IndicarTipo().ToString();
            blqtExpen.Text = viviendaNueva.CalcularExpensas().ToString();
            blqAnt.Text = viviendaNueva.CalcularAntiguedad().ToString();
            blqtAlquiler.Text = totalGastos.ToString();




        }
    }
}
