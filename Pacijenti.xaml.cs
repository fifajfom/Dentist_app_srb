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
using System.IO;

namespace OrdinacijaMihajlovic
{    
    /// <summary>
    /// Interaction logic for Pacijenti.xaml
    /// </summary>
    public partial class Pacijenti : Window
    {

        string txbx;
        

        #region MySqlConnection Connection
        //MySqlCommandBuilder cmdb1;
        MySqlDataAdapter adap;
        DataSet ds;
        MySqlConnection conn = new
        MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        #endregion
        // readonly Mysql_pacijenti Myp = new Mysql_pacijenti();



        public Pacijenti()
        {
          
            InitializeComponent();
        }


        #region !!!! Mysql class for Pacijenti !!!!


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();           
        }

        public void Refresh()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select id, ime, prezime, email, telefon, adresa, extra from pacijenti", conn);
            adap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds, "LoadDataBindingPacijenti");
            DataGridPacijent.DataContext = ds;
            Ida.Clear();
            ime.Clear();
            prezime.Clear();
            email.Clear();
            telefon.Clear();
            adresa.Clear();
            extra.Clear();
            Search.Clear();
            Save.Content = "Sačuvaj";  // Save iz buton sacuvaj
            Save.Background = Brushes.LightSkyBlue;
            conn.Close();



        }

        public void AddFolder()
        {
            string root = "Pacijenti/" + Ida.Text + "";
            
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
        }
        public void Search_DG(string search)  // don't forget string search Search_DG(string);
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from pacijenti where lower(concat(id, ime, prezime, email, telefon, adresa, extra)) like '%" + search + "%'", conn);
            adap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds, "LoadDataBindingPacijenti");
            DataGridPacijent.DataContext = ds;
            conn.Close();
        }

        public void SavePacijent()
        {
            if (Ida.Text == "")
            {
                string Ime = ime.Text;
                string Prezime = prezime.Text;
                string Email = email.Text;
                string Telefon = telefon.Text;
                string Adresa = adresa.Text;
                string Extra = extra.Text;
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "insert into pacijenti(ime, prezime, email, telefon, adresa, extra) values('" + Ime + "', '" + Prezime + "', '" + Email + "', '" + Telefon + "', '" + Adresa + "', '" + Extra + "')";
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Uspešno ste dodali novog pacijenta " + Ime + " " + Prezime + "");

                Refresh();
            }
            else
            {
                string sMessageBoxText = "Da li  želite da ažurirate pacijenta " + ime.Text + " " + prezime.Text + " ?";
                string sCaption = "Upozorenje";
                MessageBoxButton btnMessageBox = MessageBoxButton.YesNo;
                MessageBoxImage yncMessageBox = MessageBoxImage.Warning;
                MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, yncMessageBox);

                switch (rsltMessageBox)
                {
                    case MessageBoxResult.Yes:
                        Update();
                        Refresh();
                        break;

                    case MessageBoxResult.No:
                       
                        break;

                }

            }
        }

        public void Update()
        {
            string Ida = this.Ida.Text;
            string Ime = ime.Text;
            string Prezime = prezime.Text;
            string Email = email.Text;
            string Telefon = telefon.Text;
            string Adresa = adresa.Text;
            string Extra = extra.Text;
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update pacijenti set ime = '" + Ime + "' , prezime =  '" + Prezime + "',  email = '" + Email + "', telefon = '" + Telefon + "', adresa = '" + Adresa + "', extra = '" + Extra + "' where id = '" + Ida + "'";
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Uspesno ste ažurirali pacijenta " + Ime + " " + Prezime + "");

        }
        public void DeletePacijent()
        {
            string Ime = ime.Text;
            string Prezime = prezime.Text;
            string Id = Ida.Text;
            bool a1 = string.IsNullOrEmpty(Id);   // stop the null error
            if (a1 == false)
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "delete from pacijenti where id=" + Id + " ";
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Pacijent " + Ime + " " + Prezime + " je uspešno obrisan");
                
            }
            else
            {

                MessageBox.Show("Greska");
            }
            Refresh();
        }

        public void DataGridOnClick()
        {

            try
            {
                Ida.Clear();    // Try and Ida.Clear(); Stop null error
                object item = DataGridPacijent.SelectedItem;
                string ID = (DataGridPacijent.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                string IME = (DataGridPacijent.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                string PREZIME = (DataGridPacijent.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                string EMAIL = (DataGridPacijent.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                string TELEFON = (DataGridPacijent.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                string ADRESA = (DataGridPacijent.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                string EXTRA = (DataGridPacijent.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                Ida.Text = ID;
                ime.Text = IME;
                prezime.Text = PREZIME;
                email.Text = EMAIL;
                adresa.Text = ADRESA;
                telefon.Text = TELEFON;
                extra.Text = EXTRA;

            }
            catch (Exception)
            {
                //code for any other type of exception
            }
            if (Ida.Text != "")
            {
                Save.Content = "Izmeni";
                Save.Background = Brushes.LightCoral;
                
            }
            else
            {
                Save.Content = "Sačuvaj";
                Save.Background = Brushes.LightSkyBlue;
            }
        }




        #endregion !!!! Mysql class for Pacijenti !!!!



        private void DataGridPacijent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGridOnClick();

        }

        private void Osvezi_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            var search = Search.Text.ToLower().ToString();
            Search_DG(search);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {   
            SavePacijent();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string sMessageBoxText = "Da li stvarno želite da obrišete pacijenta "+ ime.Text +" "+ prezime.Text +" ?";
            string sCaption = "Upozorenje";
            MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
            MessageBoxImage yncMessageBox = MessageBoxImage.Warning;
            MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, yncMessageBox);

            switch (rsltMessageBox)
            {
                case MessageBoxResult.Yes:
                    DeletePacijent();
                    break;

                case MessageBoxResult.No:
                    Refresh();
                    break;

                case MessageBoxResult.Cancel:
                    /* ... */
                    break;
            }
            
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        

        private void Otvori_karton_Click(object sender, RoutedEventArgs e)
        {
            AddFolder();
            txbx = Ida.Text;
            Karton OK = new Karton();
            OK.Topmost = true;
            OK.IDP = txbx;
            OK.Show();
        }

        private void DataGridPacijent_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            AddFolder();
            txbx = Ida.Text;
            Karton OK = new Karton();
            OK.IDP = txbx;
            OK.Topmost = true;
            OK.Show();
        }

        private void PacW_Close(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
