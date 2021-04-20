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
using System.Windows.Resources;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace OrdinacijaMihajlovic
{
   
    /// <summary>
    /// Interaction logic for Karton.xaml
    /// </summary>
    public partial class Karton : Window
    {
        OpenFileDialog op = new OpenFileDialog();
        #region  !!! STRINGS !!!
        public string IDP;
        public string Picture;
        public string ime;
        public string prezime;
        public string beleske;
        public string PZ;
        public string IDDG;
        public string IMEDG;
        public string BELDG;
        public string PUTDG;
        public string IDODG;
        public string IDID;
        public string Put;
        public static string gl8;
        public static string gl7;
        public static string gl6;
        public static string gl5;
        public static string gl4;
        public static string gl3;
        public static string gl2;
        public static string gl1;
        public static string gd8;
        public static string gd7;
        public static string gd6;
        public static string gd5;
        public static string gd4;
        public static string gd3;
        public static string gd2;
        public static string gd1;
        public static string dl8;
        public static string dl7;
        public static string dl6;
        public static string dl5;
        public static string dl4;
        public static string dl3;
        public static string dl2;
        public static string dl1;
        public static string dd8;
        public static string dd7;
        public static string dd6;
        public static string dd5;
        public static string dd4;
        public static string dd3;
        public static string dd2;
        public static string dd1;
        public static string zgl8;
        public static string zgl7;
        public static string zgl6;
        public static string zgl5;
        public static string zgl4;
        public static string zgl3;
        public static string zgl2;
        public static string zgl1;
        public static string zgd8;
        public static string zgd7;
        public static string zgd6;
        public static string zgd5;
        public static string zgd4;
        public static string zgd3;
        public static string zgd2;
        public static string zgd1;
        public static string zdl8;
        public static string zdl7;
        public static string zdl6;
        public static string zdl5;
        public static string zdl4;
        public static string zdl3;
        public static string zdl2;
        public static string zdl1;
        public static string zdd8;
        public static string zdd7;
        public static string zdd6;
        public static string zdd5;
        public static string zdd4;
        public static string zdd3;
        public static string zdd2;
        public static string zdd1;

        #endregion !!! STRINGS !!!
        public Karton()
        {
            InitializeComponent();
        }

        readonly Pacijenti ID = new Pacijenti();

        #region MySqlConnection Connection
        //MySqlCommandBuilder cmdb1;
        MySqlDataAdapter adap;
        DataSet ds;
        MySqlConnection conn = new
        MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        #endregion


        public void RefreshKarton()
        {
            Karton_all();
            DataContext = ZubStatus.GetZub();
            BeleskeText.Text = beleske;
        }
        public void Karton_all()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select ime,prezime,beleske,gl8,gl7,gl6,gl5,gl4,gl3,gl2,gl1," +
                "gd8,gd7,gd6,gd5,gd4,gd3,gd2,gd1,dl8,dl7,dl6,dl5,dl4,dl3,dl2,dl1,dd8,dd7,dd6,dd5,dd4,dd3,dd2,dd1" +
                " from karton where idp = " + IDP + "", conn);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    ime = dr["ime"].ToString();
                    prezime = dr["prezime"].ToString();
                    beleske = dr["beleske"].ToString();
                    gl8 = dr["gl8"].ToString();
                    gl7 = dr["gl7"].ToString();
                    gl6 = dr["gl6"].ToString();
                    gl5 = dr["gl5"].ToString();
                    gl4 = dr["gl4"].ToString();
                    gl3 = dr["gl3"].ToString();
                    gl2 = dr["gl2"].ToString();
                    gl1 = dr["gl1"].ToString();
                    gd8 = dr["gd8"].ToString();
                    gd7 = dr["gd7"].ToString();
                    gd6 = dr["gd6"].ToString();
                    gd5 = dr["gd5"].ToString();
                    gd4 = dr["gd4"].ToString();
                    gd3 = dr["gd3"].ToString();
                    gd2 = dr["gd2"].ToString();
                    gd1 = dr["gd1"].ToString();
// Separator top and bottom
                    dl8 = dr["dl8"].ToString();
                    dl7 = dr["dl7"].ToString();
                    dl6 = dr["dl6"].ToString();
                    dl5 = dr["dl5"].ToString();
                    dl4 = dr["dl4"].ToString();
                    dl3 = dr["dl3"].ToString();
                    dl2 = dr["dl2"].ToString();
                    dl1 = dr["dl1"].ToString();
                    dd8 = dr["dd8"].ToString();
                    dd7 = dr["dd7"].ToString();
                    dd6 = dr["dd6"].ToString();
                    dd5 = dr["dd5"].ToString();
                    dd4 = dr["dd4"].ToString();
                    dd3 = dr["dd3"].ToString();
                    dd2 = dr["dd2"].ToString();
                    dd1 = dr["dd1"].ToString();


                }
                conn.Close();
            }
            KartonW.Title = "Karton br." + IDP + " " + ime + "" + prezime + "";
        }
        public void ZUBIC()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select gl8,gl7,gl6,gl5,gl4,gl3,gl2,gl1," +
                "gd8,gd7,gd6,gd5,gd4,gd3,gd2,gd1,dl8,dl7,dl6,dl5,dl4,dl3,dl2,dl1,dd8,dd7,dd6,dd5,dd4,dd3,dd2,dd1" +
                " from zub where idp = " + IDP + "", conn);

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {

                    zgl8 = dr["gl8"].ToString();
                    zgl7 = dr["gl7"].ToString();
                    zgl6 = dr["gl6"].ToString();
                    zgl5 = dr["gl5"].ToString();
                    zgl4 = dr["gl4"].ToString();
                    zgl3 = dr["gl3"].ToString();
                    zgl2 = dr["gl2"].ToString();
                    zgl1 = dr["gl1"].ToString();
                    zgd8 = dr["gd8"].ToString();
                    zgd7 = dr["gd7"].ToString();
                    zgd6 = dr["gd6"].ToString();
                    zgd5 = dr["gd5"].ToString();
                    zgd4 = dr["gd4"].ToString();
                    zgd3 = dr["gd3"].ToString();
                    zgd2 = dr["gd2"].ToString();
                    zgd1 = dr["gd1"].ToString();
                    // Separator top and bottom
                    zdl8 = dr["dl8"].ToString();
                    zdl7 = dr["dl7"].ToString();
                    zdl6 = dr["dl6"].ToString();
                    zdl5 = dr["dl5"].ToString();
                    zdl4 = dr["dl4"].ToString();
                    zdl3 = dr["dl3"].ToString();
                    zdl2 = dr["dl2"].ToString();
                    zdl1 = dr["dl1"].ToString();
                    zdd8 = dr["dd8"].ToString();
                    zdd7 = dr["dd7"].ToString();
                    zdd6 = dr["dd6"].ToString();
                    zdd5 = dr["dd5"].ToString();
                    zdd4 = dr["dd4"].ToString();
                    zdd3 = dr["dd3"].ToString();
                    zdd2 = dr["dd2"].ToString();
                    zdd1 = dr["dd1"].ToString();
                }
                conn.Close();
            }

        }
        public void KartonBeleske()
        {

            string textb = BeleskeText.Text;
            conn.Open();

            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update karton set beleske = '" + textb + "' where idp = '" + IDP + "'";
            comm.ExecuteNonQuery();
            conn.Close();

        }

        public void ZubShow(string pozicija, string beleskaz){
            PZ = pozicija;
            Zub zub = new Zub
            {
                IDZ = IDP,
                ZUBEL = beleskaz,
                POZ = PZ,
            };
            zub.Topmost = true;
            zub.Show();
        }
        public void ZubiPic(string sal)
        {
            Picture = sal;
            Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
            StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            Gl7.Background = brush;


        }
        public void RedTeeth()
        {
            #region !!! GORNJA LEVAA !!!
            if (gl8 == "")
            {

                Picture = "pic/gl8.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl8.Background = brush;


            }
            if (gl7 == "")
            {
                Picture = "pic/gl7.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl7.Background = brush;
            }
            if (gl6 == "")
            {
                Picture = "pic/gl6.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl6.Background = brush;
            }
            if (gl5 == "")
            {
                Picture = "pic/gl5.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl5.Background = brush;
            }
            if (gl4 == "")
            {
                Picture = "pic/gl4.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl4.Background = brush;
            }
            if (gl3 == "")
            {
                Picture = "pic/gl3.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl3.Background = brush;
            }
            if (gl2 == "")
            {
                Picture = "pic/gl2.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl2.Background = brush;
            }
            if (gl1 == "")
            {
                Picture = "pic/gl1.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl1.Background = brush;
            }
            if (gl8 != "")
            {

                    Picture = "pic/gl8r.png";
                    Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                    StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                    BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                    var brush = new ImageBrush();
                    brush.ImageSource = temp;
                    Gl8.Background = brush;

            }
            if (zgl8 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl8.Background = brush;
            }
            if (gl7 != "")
            {
                Picture = "pic/gl7r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl7.Background = brush;
            }
            if (zgl7 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl7.Background = brush;
            }
            if (gl6 != "")
            {
                Picture = "pic/gl6r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl6.Background = brush;
            }
            if (zgl6 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl6.Background = brush;
            }
            if (gl5 != "")
            {
                Picture = "pic/gl5r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl5.Background = brush;
            }
            if (zgl5 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl5.Background = brush;
            }
            if (gl4 != "")
            {
                Picture = "pic/gl4r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl4.Background = brush;
            }
            if (zgl4 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl4.Background = brush;
            }
            if (gl3 != "")
            {
                Picture = "pic/gl3r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl3.Background = brush;
            }
            if (zgl3 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl3.Background = brush;
            }
            if (gl2 != "")
            {
                Picture = "pic/gl2r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl2.Background = brush;
            }
            if (zgl2 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl2.Background = brush;
            }
            if (gl1 != "")
            {
                Picture = "pic/gl1r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl1.Background = brush;
            }
            if (zgl1 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gl1.Background = brush;
            }


            #endregion !!! GORNJA LEVA !!!

            #region !!! GORNJA DESNA !!!
            if (gd8 == "")
            {
                Picture = "pic/gd8.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd8.Background = brush;
            }
            if (gd7 == "")
            {
                Picture = "pic/gd7.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd7.Background = brush;
            }
            if (gd6 == "")
            {
                Picture = "pic/gd6.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd6.Background = brush;
            }
            if (gd5 == "")
            {
                Picture = "pic/gd5.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd5.Background = brush;
            }
            if (gd4 == "")
            {
                Picture = "pic/gd4.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd4.Background = brush;
            }
            if (gd3 == "")
            {
                Picture = "pic/gd3.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd3.Background = brush;
            }
            if (gd2 == "")
            {
                Picture = "pic/gd2.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd2.Background = brush;
            }
            if (gd1 == "")
            {
                Picture = "pic/gd1.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd1.Background = brush;
            }
            if (gd8 != "")
            {
                Picture = "pic/gd8r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd8.Background = brush;
            }
            if (zgd8 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd8.Background = brush;
            }
            if (gd7 != "")
            {
                Picture = "pic/gd7r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd7.Background = brush;
            }
            if (zgd7 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd7.Background = brush;
            }
            if (gd6 != "")
            {
                Picture = "pic/gd6r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd6.Background = brush;
            }
            if (zgd6 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd6.Background = brush;
            }
            if (gd5 != "")
            {
                Picture = "pic/gd5r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd5.Background = brush;
            }
            if (zgd5 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd5.Background = brush;
            }
            if (gd4 != "")
            {
                Picture = "pic/gd4r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd4.Background = brush;
            }
            if (zgd4 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd4.Background = brush;
            }
            if (gd3 != "")
            {
                Picture = "pic/gd3r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd3.Background = brush;
            }
            if (zgd3 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd3.Background = brush;
            }
            if (gd2 != "")
            {
                Picture = "pic/gd2r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd2.Background = brush;
            }
            if (zgd2 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd2.Background = brush;
            }
            if (gd1 != "")
            {
                Picture = "pic/gd1r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd1.Background = brush;
            }
            if (zgd1 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Gd1.Background = brush;
            }
            #endregion !!! GORNJA DESNA !!!

            #region !!! DONJA LEVA !!!

            if (dl8 == "")
            {
                Picture = "pic/dl8.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl8.Background = brush;
            }
            if (dl7 == "")
            {
                Picture = "pic/dl7.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl7.Background = brush;
            }
            if (dl6 == "")
            {
                Picture = "pic/dl6.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl6.Background = brush;
            }
            if (dl5 == "")
            {
                Picture = "pic/dl5.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl5.Background = brush;
            }
            if (dl4 == "")
            {
                Picture = "pic/dl4.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl4.Background = brush;
            }
            if (dl3 == "")
            {
                Picture = "pic/dl3.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl3.Background = brush;
            }
            if (dl2 == "")
            {
                Picture = "pic/dl2.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl2.Background = brush;
            }
            if (dl1 == "")
            {
                Picture = "pic/dl1.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl1.Background = brush;
            }

            if (dl8 != "")
            {
                Picture = "pic/dl8r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl8.Background = brush;
            }
            if (zdl8 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl8.Background = brush;
            }
            if (dl7 != "")
            {
                Picture = "pic/dl7r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl7.Background = brush;
            }
            if (zdl7 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl7.Background = brush;
            }
            if (dl6 != "")
            {
                Picture = "pic/dl6r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl6.Background = brush;
            }
            if (zdl6 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl6.Background = brush;
            }
            if (dl5 != "")
            {
                Picture = "pic/dl5r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl5.Background = brush;
            }
            if (zdl5 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl5.Background = brush;
            }
            if (dl4 != "")
            {
                Picture = "pic/dl4r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl4.Background = brush;
            }
            if (zdl4 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl4.Background = brush;
            }
            if (dl3 != "")
            {
                Picture = "pic/dl3r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl3.Background = brush;
            }
            if (zdl3 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl3.Background = brush;
            }
            if (dl2 != "")
            {
                Picture = "pic/dl2r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl2.Background = brush;
            }
            if (zdl2 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl2.Background = brush;
            }
            if (dl1 != "")
            {
                Picture = "pic/dl1r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl1.Background = brush;
            }
            if (zdl1 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dl1.Background = brush;
            }

            #endregion !!! DONJA LEVA !!!

            #region !!! DONJA DESNA !!!

            if (dd8 == "")
            {
                Picture = "pic/dd8.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd8.Background = brush;
            }
            if (dd7 == "")
            {
                Picture = "pic/dd7.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd7.Background = brush;
            }
            if (dd6 == "")
            {
                Picture = "pic/dd6.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd6.Background = brush;
            }
            if (dd5 == "")
            {
                Picture = "pic/dd5.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd5.Background = brush;
            }
            if (dd4 == "")
            {
                Picture = "pic/dd4.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd4.Background = brush;
            }
            if (dd3 == "")
            {
                Picture = "pic/dd3.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd3.Background = brush;
            }
            if (dd2 == "")
            {
                Picture = "pic/dd2.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd2.Background = brush;
            }
            if (dd1 == "")
            {
                Picture = "pic/dd1.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd1.Background = brush;
            }

            if (dd8 != "")
            {
                Picture = "pic/dd8r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd8.Background = brush;
            }
            if (zdd8 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd8.Background = brush;
            }
            if (dd7 != "")
            {
                Picture = "pic/dd7r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd7.Background = brush;
            }
            if (zdd7 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd7.Background = brush;
            }
            if (dd6 != "")
            {
                Picture = "pic/dd6r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd6.Background = brush;
            }
            if (zdd6 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd6.Background = brush;
            }
            if (dd5 != "")
            {
                Picture = "pic/dd5r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd5.Background = brush;
            }
            if (zdd5 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd5.Background = brush;
            }
            if (dd4 != "")
            {
                Picture = "pic/dd4r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd4.Background = brush;
            }
            if (zdd4 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd4.Background = brush;
            }
            if (dd3 != "")
            {
                Picture = "pic/dd3r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd3.Background = brush;
            }
            if (zdd3 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd3.Background = brush;
            }
            if (dd2 != "")
            {
                Picture = "pic/dd2r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd2.Background = brush;
            }
            if (zdd2 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd2.Background = brush;
            }
            if (dd1 != "")
            {
                Picture = "pic/dd1r.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd1.Background = brush;
            }
            if (zdd1 == "1")
            {
                Picture = "pic/missing.png";
                Uri resourceUri = new Uri("" + Picture + "", UriKind.Relative);
                StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;
                Dd1.Background = brush;
            }

            #endregion !!! DONJA DESNA !!!

        }
        public class ZubStatus
        {
            public string TeethEmpty { get; private set; }
            public string TeethFullgl8 { get; private set; }
            public string TeethFullgl7 { get; private set; }
            public string TeethFullgl6 { get; private set; }
            public string TeethFullgl5 { get; private set; }
            public string TeethFullgl4 { get; private set; }
            public string TeethFullgl3 { get; private set; }
            public string TeethFullgl2 { get; private set; }
            public string TeethFullgl1 { get; private set; }
            public string TeethFullgd8 { get; private set; }
            public string TeethFullgd7 { get; private set; }
            public string TeethFullgd6 { get; private set; }
            public string TeethFullgd5 { get; private set; }
            public string TeethFullgd4 { get; private set; }
            public string TeethFullgd3 { get; private set; }
            public string TeethFullgd2 { get; private set; }
            public string TeethFullgd1 { get; private set; }
            public string TeethFulldl8 { get; private set; }
            public string TeethFulldl7 { get; private set; }
            public string TeethFulldl6 { get; private set; }
            public string TeethFulldl5 { get; private set; }
            public string TeethFulldl4 { get; private set; }
            public string TeethFulldl3 { get; private set; }
            public string TeethFulldl2 { get; private set; }
            public string TeethFulldl1 { get; private set; }
            public string TeethFulldd8 { get; private set; }
            public string TeethFulldd7 { get; private set; }
            public string TeethFulldd6 { get; private set; }
            public string TeethFulldd5 { get; private set; }
            public string TeethFulldd4 { get; private set; }
            public string TeethFulldd3 { get; private set; }
            public string TeethFulldd2 { get; private set; }
            public string TeethFulldd1 { get; private set; }
            public static ZubStatus GetZub()
            {
                var emp = new ZubStatus()
                {
                    TeethEmpty = "Zub nije rađen, ili nije nista upisano",
                    TeethFullgl8 = "" + gl8 + "",
                    TeethFullgl7 = "" + gl7 + "",
                    TeethFullgl6 = "" + gl6 + "",
                    TeethFullgl5 = "" + gl5 + "",
                    TeethFullgl4 = "" + gl4 + "",
                    TeethFullgl3 = "" + gl3 + "",
                    TeethFullgl2 = "" + gl2 + "",
                    TeethFullgl1 = "" + gl1 + "",
                    TeethFullgd8 = "" + gd8 + "",
                    TeethFullgd7 = "" + gd7 + "",
                    TeethFullgd6 = "" + gd6 + "",
                    TeethFullgd5 = "" + gd5 + "",
                    TeethFullgd4 = "" + gd4 + "",
                    TeethFullgd3 = "" + gd3 + "",
                    TeethFullgd2 = "" + gd2 + "",
                    TeethFullgd1 = "" + gd1 + "",
                    TeethFulldl8 = "" + dl8 + "",
                    TeethFulldl7 = "" + dl7 + "",
                    TeethFulldl6 = "" + dl6 + "",
                    TeethFulldl5 = "" + dl5 + "",
                    TeethFulldl4 = "" + dl4 + "",
                    TeethFulldl3 = "" + dl3 + "",
                    TeethFulldl2 = "" + dl2 + "",
                    TeethFulldl1 = "" + dl1 + "",
                    TeethFulldd8 = "" + dd8 + "",
                    TeethFulldd7 = "" + dd7 + "",
                    TeethFulldd6 = "" + dd6 + "",
                    TeethFulldd5 = "" + dd5 + "",
                    TeethFulldd4 = "" + dd4 + "",
                    TeethFulldd3 = "" + dd3 + "",
                    TeethFulldd2 = "" + dd2 + "",
                    TeethFulldd1 = "" + dd1 + "",
                };
                return emp;
            }
        }
        public void DataGrid()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select id, imefajla,beleske,putanja,idp from zfiles where idp = '" + IDP + "'", conn);
            adap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds, "LoadDataBindingFajlovi");
            Karton_files.DataContext = ds;
            conn.Close();
            
        }

        public void DataGridBeleske()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select id,beleske from pacijent_beleske where idp = '" + IDP + "'", conn);
            adap = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adap.Fill(ds, "LoadDataBindingBeleske");
            BeleskeDG.DataContext = ds;
            conn.Close();

        }
        private void KartonW_Loaded(object sender, RoutedEventArgs e)
        {
            ZUBIC();
            Karton_all();
            DataContext = ZubStatus.GetZub();
            BeleskeText.Text = beleske;
            RedTeeth();
            DataGrid();
            DataGridBeleske();
          

        }
        public void DeleteFiles()
        {
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "delete from zfiles where id=" + IDODG + " ";
            comm.ExecuteNonQuery();
           conn.Close();
           MessageBox.Show("Fajl " + IMEDG + " je obrisan ");
            File.Delete("" + PUTDG + "\\" + IDP + "\\" + IMEDG + "");
        }
        public void SaveFiles()
        {
            string ss = Put;

            string dest = "Pacijent/" + IDP + "";
            string sourceFile = ss;
            string destinationFile = "Pacijenti/" + IDP + "/"+ImeFajla.Text+"";
            try
            {
                if (ImeFajla.Text != "")
                {

                File.Copy(sourceFile, destinationFile, true);
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "insert into zfiles (imefajla,beleske,idp) values ( '" + ImeFajla.Text + "','" + Beleske.Text + "','" + IDP + "')";
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Uspešno ste sačuvali fajl " + ImeFajla.Text + "");
                }
                else
                {
                    MessageBox.Show("Niste odabrali ni jedan fajl da sačuvate");
                }
                // MessageBox.Show("" + ImeFajla.Text + "  " + Beleske.Text + "  " + Put + "  " + IDP + " ");
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);

            }

        }
        public void UpdateBeleske()
        {
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update pacijent_beleske set beleske='" + BeleskeText.Text + "' where id ='" + IDID + "'";
            comm.ExecuteNonQuery();
            conn.Close();
        }
        public void SaveBeleske()
        {
            if( IDID != "")
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "insert into pacijent_beleske (beleske,idp) values ( '" + BeleskeText.Text + "','" + IDP + "')";
                comm.ExecuteNonQuery();
                conn.Close();
                BeleskeText.Clear();
                DataGridBeleske();
            }
            else
            {
                UpdateBeleske();
                DataGridBeleske();
                BeleskeText.Clear();
            }
        }
        public void DeleteBeleske()
        {
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "delete from pacijent_beleske where id = '"+IDID+"'";
            comm.ExecuteNonQuery();
            conn.Close();
        }

        #region !!!!!!!!!! TEETH BUTTONS !!!!!!!!!!!

        private void Gl8_Click(object sender, RoutedEventArgs e)
        {   
            string poz = "gl8";
            ZubShow(poz,poz);
         
        }

        private void Gl7_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gl7";
            ZubShow(poz,poz);
  
        }

        private void Gl6_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gl6";
            ZubShow(poz, poz);
        }

        private void Gl5_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gl5";
            ZubShow(poz, poz);
        }

        private void Gl4_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gl4";
            ZubShow(poz, poz);
        }

        private void Gl3_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gl3";
            ZubShow(poz, poz);
        }

        private void Gl2_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gl2";
            ZubShow(poz, poz);
        }

        private void Gl1_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gl1";
            ZubShow(poz, poz);
        }

        private void Gd1_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gd1";
            ZubShow(poz, poz);
        }

        private void Gd2_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gd2";
            ZubShow(poz, poz);
        }

        private void Gd3_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gd3";
            ZubShow(poz, poz);
        }

        private void Gd4_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gd4";
            ZubShow(poz, poz);
        }

        private void Gd5_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gd5";
            ZubShow(poz, poz);
        }

        private void Gd6_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gd6";
            ZubShow(poz, poz);
        }

        private void Gd7_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gd7";
            ZubShow(poz, poz);
        }

        private void Gd8_Click(object sender, RoutedEventArgs e)
        {
            string poz = "gd8";
            ZubShow(poz, poz);
        }

        private void Dl8_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dl8";
            ZubShow(poz, poz);
        }

        private void Dl7_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dl7";
            ZubShow(poz, poz);
        }

        private void Dl6_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dl6";
            ZubShow(poz, poz);
        }

        private void Dl5_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dl5";
            ZubShow(poz, poz);
        }

        private void Dl4_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dl4";
            ZubShow(poz, poz);
        }

        private void Dl3_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dl3";
            ZubShow(poz, poz);
        }

        private void Dl2_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dl2";
            ZubShow(poz, poz);
        }

        private void Dl1_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dl1";
            ZubShow(poz, poz);
        }

        private void Dd1_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dd1";
            ZubShow(poz, poz);
        }

        private void Dd2_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dd2";
            ZubShow(poz, poz);
        }

        private void Dd3_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dd3";
            ZubShow(poz, poz);
        }

        private void Dd4_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dd4";
            ZubShow(poz, poz);
        }

        private void Dd5_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dd5";
            ZubShow(poz, poz);
        }

        private void Dd6_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dd6";
            ZubShow(poz, poz);
        }

        private void Dd7_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dd7";
            ZubShow(poz, poz);
        }
        private void Dd8_Click(object sender, RoutedEventArgs e)
        {
            string poz = "dd8";
            ZubShow(poz, poz);
        }


         



        #endregion  !!!!!!!!!! TEETH BUTTONS !!!!!!!!!!!

        private void UpBeleske_Click(object sender, RoutedEventArgs e)
        {
            if (IdBeleske.Text != "")
            {
                UpdateBeleske();
                DataGridBeleske();
                IdBeleske.Clear();
                BeleskeText.Clear();
                UpBeleske.Content = "Sačuvaj";
                UpBeleske.Background = Brushes.LightSkyBlue;
            }
            else
            {
                SaveBeleske();
                DataGridBeleske();
                BeleskeText.Clear();
                IdBeleske.Clear();
            }
        }

        private void Kartonw_activated(object sender, EventArgs e)
        {

            ZUBIC();
            Karton_all();
            DataContext = ZubStatus.GetZub();
            RedTeeth();
            DataGrid();
           
       
        }

        private void BeleskeText_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void BeleskeText_keydown(object sender, KeyEventArgs e)
        {
            BeleskeText.Background = Brushes.LightBlue;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
            op.Title = "Izaberi fajl";
            op.Filter = "All files (*.*)|*.*";
            if (op.ShowDialog() == true)
            {
                Put = op.FileName;
                // slika.Source = new BitmapImage(new Uri(op.FileName));
                string path = Put;
                string filename = System.IO.Path.GetFileName(path);
                ImeFajla.Text = filename;


            }
        }

        private void Sacuvaj_Click(object sender, RoutedEventArgs e)
        { if (Put == "")
            {
                MessageBox.Show("Niste izabrali ni jedan fajl da sačuvate");
            }
            else
            {
                SaveFiles();
                Put = "";
                
                ImeFajla.Clear();
                Beleske.Clear();
                DataGrid();
            }
            
        }

        private void KartonFiles_onclick(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = Karton_files.SelectedItem;
                string IDO = (Karton_files.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                string IDG = (Karton_files.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                string BDG = (Karton_files.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                string PDG = (Karton_files.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                string ID = (Karton_files.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                IDDG = ID;
                IMEDG = IDG;
                BELDG = BDG;
                PUTDG = PDG;
                IDODG = IDO;
            }
            
            catch
            {

            }
        }

        private void Brisanje_Click(object sender, RoutedEventArgs e)
        {
            string sMessageBoxText = "Da li stvarno želite da obrišete fajl " + IMEDG + " ?";
            string sCaption = "Upozorenje";
            MessageBoxButton btnMessageBox = MessageBoxButton.YesNo;
            MessageBoxImage yncMessageBox = MessageBoxImage.Warning;
            MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, yncMessageBox);

            switch (rsltMessageBox)
            {
                case MessageBoxResult.Yes:
                    DeleteFiles();
                    DataGrid();
                    break;

                case MessageBoxResult.No:
                    DataGrid();
                    break;

  
            }

        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {


            System.Diagnostics.Process.Start("" + PUTDG + "\\" +IDP+ "\\" + IMEDG + "");

        }

        private void KartonW_close(object sender, EventArgs e)
        {
            
        }

        private void Karton_files_double(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("" + PUTDG + "\\" + IDP + "\\" + IMEDG + "");
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)  //Delete button
        {
            DeleteBeleske();
            DataGridBeleske();
            BeleskeText.Clear();
        }

        private void BeleskeDG_Click(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = BeleskeDG.SelectedItem;

                string ID = (BeleskeDG.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                string BELID = (BeleskeDG.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                IDID = ID;
                BeleskeText.Text = BELID;
                IdBeleske.Text = ID;

            }

            catch
            {

            }
            if (BeleskeText.Text != "")
            {
                UpBeleske.Content = "Izmeni";
                UpBeleske.Background = Brushes.LightCoral;

            }
            else
            {
                UpBeleske.Content = "Sačuvaj";
                UpBeleske.Background = Brushes.LightSkyBlue;
            }
        }

        private void Osvezi_Click(object sender, RoutedEventArgs e)
        {
            IdBeleske.Clear();
            BeleskeText.Clear();
            DataGridBeleske();
        }
    }
    
}
