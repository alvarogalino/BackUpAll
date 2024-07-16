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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionZoo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;
        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["ConexionZoo.Properties.Settings.ZooConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            MostrarAnimales();
        }

        private void MostrarAnimales()
        {
            string consultaAnimales = "SELECT * FROM ESPECIE ";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consultaAnimales, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable especieAnimal= new DataTable();
                miAdaptadorSql.Fill(especieAnimal);

                lbxAnimales.DisplayMemberPath = "Especie";
                lbxAnimales.SelectedValuePath = "Id";
                lbxAnimales.ItemsSource = especieAnimal.DefaultView;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
