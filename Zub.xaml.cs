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
using System.Windows.Shapes;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace OrdinacijaMihajlovic
{
    /// <summary>
    /// Interaction logic for Zub.xaml
    /// </summary>
    public partial class Zub : Window
    {
        public string IME;
        public string IZVZ;
        public string IDZ;  // table ID
        public string POZ; // Teeth Position
        public string ZUBEL;
        public string belz;
        public string IDDG;
        public string BELDG;


        #region MySqlConnection Connection
        //MySqlCommandBuilder cmdb1;
        MySqlDataAdapter adap;
        DataSet ds;
        MySqlConnection conn = new
        MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        #endregion

        public Zub()
        {
            InitializeComponent();
        }

        Karton kart = new Karton();

        public void ChangeNamez()
        {
            if (POZ == "gl1")
            {
                IME = "11";
            }
            if (POZ == "gl2")
            {
                IME = "12";
            }
            if (POZ == "gl3")
            {
                IME = "13";
            }
            if (POZ == "gl4")
            {
                IME = "14";
            }
            if (POZ == "gl5")
            {
                IME = "15";
            }
            if (POZ == "gl6")
            {
                IME = "16";
            }
            if (POZ == "gl7")
            {
                IME = "17";
            }
            if (POZ == "gl8")
            {
                IME = "18";
            }
            if (POZ == "gd1")
            {
                IME = "21";
            }
            if (POZ == "gd2")
            {
                IME = "22";
            }
            if (POZ == "gd3")
            {
                IME = "23";
            }
            if (POZ == "gd4")
            {
                IME = "24";
            }
            if (POZ == "gd5")
            {
                IME = "25";
            }
            if (POZ == "gd6")
            {
                IME = "26";
            }
            if (POZ == "gd7")
            {
                IME = "27";
            }
            if (POZ == "gd8")
            {
                IME = "28";
            }
            if (POZ == "dl1")
            {
                IME = "41";
            }
            if (POZ == "dl2")
            {
                IME = "42";
            }
            if (POZ == "dl3")
            {
                IME = "43";
            }
            if (POZ == "dl4")
            {
                IME = "44";
            }
            if (POZ == "dl5")
            {
                IME = "45";
            }
            if (POZ == "dl6")
            {
                IME = "46";
            }
            if (POZ == "dl7")
            {
                IME = "47";
            }
            if (POZ == "dl8")
            {
                IME = "48";
            }
            if (POZ == "dd1")
            {
                IME = "31";
            }
            if (POZ == "dd2")
            {
                IME = "32";
            }
            if (POZ == "dd3")
            {
                IME = "33";
            }
            if (POZ == "dd4")
            {
                IME = "34";
            }
            if (POZ == "dd5")
            {
                IME = "35";
            }
            if (POZ == "dd6")
            {
                IME = "36";
            }
            if (POZ == "dd7")
            {
                IME = "37";
            }
            if (POZ == "dd8")
            {
                IME = "38";
            }

        }
        public void MyZubDelete()
        {
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "delete from zub_beleske where id=" + IDDG + " ";
            comm.ExecuteNonQuery();
            conn.Close();
            ZubText.Clear();
        }
        public void MyZubLoad()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select " + ZUBEL + " from karton where idp = " + IDZ + "", conn);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    belz = dr["" + ZUBEL + ""].ToString();
                }
                conn.Close();
            }
            ChangeNamez();
            ZubW.Title = "Zub " + IME + "";
            Check();




        }
        public void MyZub2()
        {
            string dat = Datum.Text;
            string updz = ZubText.Text;
            conn.Open();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update karton set " + POZ + " = '" + updz + "' where idp = '" + IDZ + "' ";

            comm.ExecuteNonQuery();
            conn.Close();
            ZubDataGrid();

        }
        public void MyZub()
        {
            string iDate = Datum.Text;
            DateTime oDate = Convert.ToDateTime(iDate);
            //MessageBox.Show(oDate.Year + "-" + oDate.Month + "-" + oDate.Day);
            string dat = oDate.Year + "-" + oDate.Month + "-" + oDate.Day;
            string updz = ZubText.Text;
            conn.Open();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "insert into zub_beleske (idp,datum,beleske,idz) values ('" + IDZ + "','" + dat + "','" + updz + "','" + POZ + "')";
            comm.ExecuteNonQuery();
            conn.Close();
            ZubDataGrid();

        }
        public void ZubDataGrid()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select id, datum,beleske   from zub_beleske  where (idp = '" + IDZ + "' and  idz='" + POZ + "') order by datum DESC", conn);
            adap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds, "LoadDataBindingZubi");
            Zub_datagrid.DataContext = ds;
            conn.Close();
            
        }
        public void Check()
        {
            string namez = POZ;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select " + namez + " from zub  where idp = '" + IDZ + "'", conn);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    IZVZ = dr["" + namez + ""].ToString();

                }
                conn.Close();
            }
            if (IZVZ == "1")
            {
                ZubDugme2.Visibility = Visibility.Visible;
                ZubDugme.Visibility = Visibility.Hidden;

            }
            else
            {
                ZubDugme.Visibility = Visibility.Visible;
                ZubDugme2.Visibility = Visibility.Hidden;

            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            MyZubDelete();
            ZubDataGrid();
        }

        private void UpdateZub_Click(object sender, RoutedEventArgs e)
        {   if (ZubText.Text == "")
            {
                string sMessageBoxText = "Čuvanjem praznog polja, zub će se resetovati (postaće bezbojan)      Da li želite da sačuvate prazno polje ?";
                string sCaption = "Upozorenje";
                MessageBoxButton btnMessageBox = MessageBoxButton.YesNo;
                MessageBoxImage yncMessageBox = MessageBoxImage.Warning;
                MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, yncMessageBox);

                switch (rsltMessageBox)
                {
                    case MessageBoxResult.Yes:
                        MyZub2();
                        MyZub();
                        ZubDataGrid();
                        ZubText.Clear();
                        // Close();
                        break;

                    case MessageBoxResult.No:

                        break;


                }
 
            }
            else
            {
                MyZub2();
                MyZub();
                ZubDataGrid();
                ZubText.Clear();
            }



        }

        private void ZubLoad(object sender, RoutedEventArgs e)
        {
            ZubDataGrid();
            MyZubLoad();
            Datum.SelectedDate = DateTime.Today;
            Izmeni.IsEnabled = false;
        }



        private void ZubDugme_Click(object sender, RoutedEventArgs e)
        {
            string namez = POZ;
            conn.Open();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update zub set " + namez + " = '1' where idp = '" + IDZ + "'";
            comm.ExecuteNonQuery();
            conn.Close();
            Check();

        }

        private void ZubDugme2_Click(object sender, RoutedEventArgs e)
        {
            string namez = POZ;
            conn.Open();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update zub set " + namez + " = '' where idp = '" + IDZ + "'";
            comm.ExecuteNonQuery();
            conn.Close();
            Check();
        }

        private void ZubW_Close(object sender, EventArgs e)
        {
        }

        private void Zub_datagrid_OnClick(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = Zub_datagrid.SelectedItem;
                string ID = (Zub_datagrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                //string DA = (Zub_datagrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                string BEL = (Zub_datagrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                
                IDDG = ID;
                BELDG = BEL;
                ZubText.Text = BEL;
                UpdateZub.IsEnabled = false;
                Izmeni.IsEnabled = true;
            }
            catch
            {

            }

        }
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            ZubDataGrid();
            ZubText.Clear();
            UpdateZub.IsEnabled = true;
            Izmeni.IsEnabled = false;

        }

        private void Izmeni_Click(object sender, RoutedEventArgs e)
        {
            string updz = ZubText.Text;
            conn.Open();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update zub_beleske set beleske = '" + updz + "' where id = '" + IDDG + "' ";

            comm.ExecuteNonQuery();
            conn.Close();
            ZubDataGrid();
            ZubText.Clear();
            UpdateZub.IsEnabled = true;
            Izmeni.IsEnabled = false;
        }
    }
    
}
