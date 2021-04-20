using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace OrdinacijaMihajlovic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OrdinacijaMihajlovic.Mysql_main om = new Mysql_main();
        public MainWindow()
        {   

            om.Mysql2();

            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           

        }  //for later project

        #region Await for gif to load then execute
        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            await Task.Delay(2500); // await for gif to load
            if (om.rezultat == "1")
            {
                Pacijenti paci = new Pacijenti();
                paci.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška u komunikaciji sa bazom");
                this.Close();
            }
          
        }
        #endregion

    }
}
