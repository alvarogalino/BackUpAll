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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ZoologicoExamen
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

            string miConexion = ConfigurationManager.ConnectionStrings["ZoologicoExamen.Properties.Settings.ZooConnectionString"].ConnectionString; 

            miConexionSql = new SqlConnection(miConexion);

            CargarZoologicos();
            
        }


        private void CargarZoologicos()
        {
            string consultaCiudad = "SELECT * FROM CIUDAD";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consultaCiudad, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable cCiudad = new DataTable();
                miAdaptadorSql.Fill(cCiudad);
                lbxListaZoos.DisplayMemberPath = "Ciudad";
                lbxListaZoos.SelectedValuePath = "Id";
                lbxListaZoos.ItemsSource = cCiudad.DefaultView;
            }
        }

        private void CargarAnimales()
        {
            try
            {
                string consultaEspecie = "SELECT * FROM ESPECIE";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consultaEspecie, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable cEspecie = new DataTable();
                    miAdaptadorSql.Fill(cEspecie);
                    lbxListaAnimalesAgregar.DisplayMemberPath = "Especie";
                    lbxListaAnimalesAgregar.SelectedValuePath = "Id";
                    lbxListaAnimalesAgregar.ItemsSource = cEspecie.DefaultView;
                }
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void MuestraAnimalesAsociados()
        {

            try
            {
                string consulta = "select * from Especie a Inner Join EspecieZoo az on a.Id = az.AnimalId where az.ZooId = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", lbxListaZoos.SelectedValue);

                    DataTable AnimalTabla = new DataTable();
                    sqlDataAdapter.Fill(AnimalTabla);

                    lbxListaAnimales.DisplayMemberPath = "Especie";
                    lbxListaAnimales.SelectedValuePath = "Id";
                    lbxListaAnimales.ItemsSource = AnimalTabla.DefaultView;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void MuestraZooElegidoEnTextBox()
        {
            try
            {
                string consulta = "select Ciudad from Ciudad where Id = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", lbxListaZoos.SelectedValue);

                    DataTable ZooDataTabla = new DataTable();
                    sqlDataAdapter.Fill(ZooDataTabla);

                    txtResumen.Text = ZooDataTabla.Rows[0]["Ciudad"].ToString();
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void MuestraAnimalElegidoEnTextBox()
        {
            try
            {
                string consulta = "select Especie from Especie where Id = @AnimalId";

                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", lbxListaAnimalesAgregar.SelectedValue);

                    DataTable ZooDataTabla = new DataTable();
                    sqlDataAdapter.Fill(ZooDataTabla);

                    txtResumen.Text = ZooDataTabla.Rows[0]["Especie"].ToString();
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }



        private void lbxListaZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraAnimalesAsociados();
            MuestraZooElegidoEnTextBox();

        }

        private void btnEliminarZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "Delete from Ciudad where id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", lbxListaZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                miConexionSql.Close();
                CargarZoologicos();
            }

        }

        private void btnAgregarZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "Insert into Ciudad values (@Ciudad)";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();
                sqlCommand.Parameters.AddWithValue("@Ciudad", txtResumen.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                miConexionSql.Close();
                CargarZoologicos();
            }
        }

        private void btnAgregarAnimalAZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "Insert into EspecieZoo values (@ZooId, @AnimalId)";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", lbxListaZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalId", lbxListaAnimalesAgregar.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                miConexionSql.Close();
                MuestraAnimalesAsociados();
            }
        }

        private void btnActualizarZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "Update Ciudad Set Ciudad = @Ciudad where Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", lbxListaZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Ubicacion", txtResumen.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                miConexionSql.Close();
                CargarZoologicos();
            }
        }

        private void btnActualizarAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "Update Especie Set Especie = @Especie where Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", lbxListaAnimalesAgregar.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Nombre", txtResumen.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                miConexionSql.Close();
                CargarAnimales();
            }
        }

        private void btnEliminarAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "Delete from Especie where id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", lbxListaAnimalesAgregar.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                miConexionSql.Close();
                CargarAnimales();
            }
        }

        private void btnAgregarAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "Insert into Especie values (@Especie)";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();
                sqlCommand.Parameters.AddWithValue("@Nombre", txtResumen.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                miConexionSql.Close();
                CargarAnimales();
            }
        }

        private void ListaAnimales_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraAnimalElegidoEnTextBox();
        }




    }
}
