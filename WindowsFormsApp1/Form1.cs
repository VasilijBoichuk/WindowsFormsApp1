using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
        }
        private void streetOrPlaceName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = WindowsIdentity.GetCurrent().Name.Split('\\')[1];

            if (streetOrPlaceName.Text == "" || streetOrPlaceName.Text == " ")
            {
                CustomMessageBox.Show("LŪDZU IEVADIET DATUS!");
                streetOrPlaceName.Focus();
                return;
            }
            
            counter++;
            TextWriter tw = new StreamWriter("C:/Users/WinMac/source/repos/WindowsFormsApp1/Counter.txt");
            tw.WriteLine(counter.ToString());
            tw.Close();

            switch (streetOrPlaceName.Text)
            {
                case "maija":
                case "Maija":
                case "MAIJA":
                    {
                        string maija = $@"C:\Users\{username}\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\maija.png";
                        Process.Start("chrome.exe", maija);
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54280%2C27.71850%3B56.54530%2C27.72520#map=17/56.54404/27.72197&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "novembra":
                case "Novembra":
                case "NOVEMBRA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\novembra.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54285%2C27.71850%3B56.54200%2C27.71348#map=18/56.54300/27.71625&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "andreja upisa":
                case "Andreja upisa":
                case "Andreja Upisa":
                case "ANDREJA UPISA":
                case "upisa":
                case "Upisa":
                case "UPISA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\upisa.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54586%2C27.71619");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "aroniju":
                case "Aroniju":
                case "ARONIJU":
                    {
                        CustomMessageBox.Show("RUNTORTA (Dačas)    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\aroniju.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54289%2C27.71848%3B56.52499%2C27.68875#map=14/56.5358/27.7039&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "atputas":
                case "Atputas":
                case "ATPUTAS":
                    {
                        CustomMessageBox.Show("RUNTORTA    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\atputas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5288%2C27.6950#map=14/56.5377/27.7070&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "baznicas":
                case "Baznicas":
                case "BAZNICAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\baznicas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5472%2C27.7175");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "birzas":
                case "Birzas":
                case "BIRZAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\birzas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54280%2C27.71850%3B56.53940%2C27.71190");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "blaumana":
                case "Blaumana":
                case "BLAUMANA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\blaumana.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54167%2C27.71888#map=18/56.54226/27.71893&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "cerinu":
                case "Cerinu":
                case "CERINU":
                    {
                        CustomMessageBox.Show("RUNTORTA (Dačas)    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\cerinu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.52578%2C27.68922#map=14/56.5358/27.7037&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "cigorinu":
                case "Cigorinu":
                case "CIGORINU":
                    {
                        CustomMessageBox.Show("RUNTORTA (Dačas)    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\cigorinu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54288%2C27.71840%3B56.52529%2C27.68829#map=14/56.5358/27.7037&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "dagdas":
                case "Dagdas":
                case "DAGDAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\dagdas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5381%2C27.7048");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "dzirnavu":
                case "Dzirnavu":
                case "DZIRNAVU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\dzirnavu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5428%2C27.7184%3B56.5367%2C27.7322#map=16/56.5406/27.7255&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "dunaklu":
                case "Dunaklu":
                case "DUNAKLU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\dunaklu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54282%2C27.71847%3B56.55692%2C27.72499#map=15/56.5499/27.7229&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "dzelzcela":
                case "Dzelzcela":
                case "DZELZCELA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\dzelzcela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5340%2C27.7356#map=15/56.5393/27.7272&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "gaismas":
                case "Gaismas":
                case "GAISMAS":
                    {
                        CustomMessageBox.Show("RUNTORTA (Dačas)    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\gaismas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5283%2C27.6938");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "jauna":
                case "Jauna":
                case "JAUNA":
                    {
                        CustomMessageBox.Show("MARTIŠOS    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\jauna.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5216%2C27.7361#map=14/56.5331/27.7279&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "jelgavas":
                case "Jelgavas":
                case "JELGAVAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\jelgavas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5427%2C27.7185%3B56.5370%2C27.7194");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "jurdza":
                case "Jurdza":
                case "JURDZA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\jurdza.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5466%2C27.7342");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "karsavas":
                case "Karsavas":
                case "KARSAVAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\karsavas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_bike&route=56.54275%2C27.71851%3B56.55102%2C27.72194#map=15/56.5470/27.7232&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "kempa":
                case "Kempa":
                case "KEMPA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\kempa.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.53922%2C27.71588");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "klusa":
                case "Klusa":
                case "KLUSA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\klusa.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5493%2C27.6969#map=15/56.5453/27.7080&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "krasta":
                case "Krasta":
                case "KRASTA":
                    {
                        CustomMessageBox.Show("RUNTORTA (Dačas)    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\krasta.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5259%2C27.6905");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "barona":
                case "Barona":
                case "BARONA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\barona.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54605%2C27.71810#map=17/56.54446/27.71850&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "kraslavas":
                case "Kraslavas":
                case "KRASLAVAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\kraslavas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5374%2C27.6982#map=15/56.5420/27.7085&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "kulneva":
                case "Kulneva":
                case "KULNEVA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\kulneva.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5428%2C27.7185%3B56.5508%2C27.7274#map=16/56.5468/27.7227&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "latgales":
                case "Latgales":
                case "LATGALES":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\latgales.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54290%2C27.71850%3B56.54653%2C27.71779#map=17/56.54472/27.71841&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "liepajas":
                case "Liepajas":
                case "LIEPAJAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\liepajas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.53848%2C27.70998#map=16/56.5407/27.7145&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "lica":
                case "Lica":
                case "LICA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\lica.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54615%2C27.70915");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "ludzas":
                case "Ludzas":
                case "LUDZAS":
                    {
                        CustomMessageBox.Show("MARTIŠOS    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\ludzas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5253%2C27.7365#map=14/56.5349/27.7279&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "miera":
                case "Miera":
                case "MIERA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\miera.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_bike&route=56.5429%2C27.7185%3B56.5513%2C27.7264");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "niedru":
                case "Niedru":
                case "NIEDRU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\niedru.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5567%2C27.7219");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "ozolu":
                case "Ozolu":
                case "OZOLU":
                    {
                        CustomMessageBox.Show("RUNTORTA    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\ozolu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.52575%2C27.69072#map=14/56.5362/27.7048&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "liepu":
                case "Liepu":
                case "LIEPU":
                    {
                        CustomMessageBox.Show("MARTIŠOS    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\liepu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.52541%2C27.73644#map=14/56.5350/27.7279&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "miglinieka":
                case "Miglinieka":
                case "MIGLINIEKA":
                case "miglinika":
                case "Miglinika":
                case "MIGLINIKA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\miglinika.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5428%2C27.7185%3B56.5395%2C27.7192#map=16/56.5411/27.7190&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "odu":
                case "Odu":
                case "ODU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\odu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5470%2C27.7315");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "paegles":
                case "Paegles":
                case "PAEGLES":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\paegles.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54283%2C27.71833%3B56.53719%2C27.69317#map=15/56.5419/27.7061&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "parku":
                case "Parku":
                case "PARKU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\parku.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54692%2C27.71475#map=16/56.5449/27.7169&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "peldu":
                case "Peldu":
                case "PELDU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\peldu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54536%2C27.70992#map=17/56.54470/27.71419&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "plavu":
                case "Plavu":
                case "PLAVU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\plavu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5566%2C27.7221");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "purenu":
                case "Purenu":
                case "PURENU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\purenu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5356%2C27.7252#map=16/56.5392/27.7220&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "puskina":
                case "Puskina":
                case "PUSKINA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\puskina.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54009%2C27.72286");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "raina":
                case "Raina":
                case "RAINA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\raina.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5440%2C27.7187#map=18/56.54345/27.71888&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "rekaseva":
                case "Rekaseva":
                case "REKASEVA":
                case "rekasova":
                case "Rekasova":
                case "REKASOVA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\rekasova.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54429%2C27.72295#map=18/56.54357/27.72084&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "rupniecibas":
                case "Rupniecibas":
                case "RUPNIECIBAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\rupniecibas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5428%2C27.7037");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "saules":
                case "Saules":
                case "SAULES":
                    {
                        CustomMessageBox.Show("Saules iela ir arī MARTIŠOS\n\nŠitais maršrūts priekš LUDZAS");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\saules.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5374%2C27.7278#map=16/56.5401/27.7233&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "skolas":
                case "Skolas":
                case "SKOLAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\skolas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54286%2C27.71901#map=19/56.54286/27.71901&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "smilsu":
                case "Smilsu":
                case "SMILSU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\smilsu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_bike&route=56.54287%2C27.71848%3B56.55251%2C27.72626#map=15/56.5477/27.7232&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "soikana":
                case "Soikana":
                case "SOIKANA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\soikana.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_bike&route=56.5429%2C27.7185%3B56.5508%2C27.7242");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "sporta":
                case "Sporta":
                case "SPORTA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\sporta.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54061%2C27.72490#map=16/56.5412/27.7219&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "stacijas":
                case "Stacijas":
                case "STACIJAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\stacijas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54411%2C27.72045");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "stroda":
                case "Stroda":
                case "STRODA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\stroda.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54166%2C27.71780#map=18/56.54223/27.71841&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "talavijas":
                case "Talavijas":
                case "TALAVIJAS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\talavijas.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54284%2C27.71848%3B56.54468%2C27.72709#map=17/56.54375/27.72293&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "tirgus":
                case "Tirgus":
                case "TIRGUS":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\tirgus.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54499%2C27.72029#map=17/56.54393/27.71961&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "zala":
                case "Zala":
                case "ZALA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\zala.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5555%2C27.7225");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "ziedu":
                case "Ziedu":
                case "ZIEDU":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\ziedu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5385%2C27.7238");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "lauku skersiela":
                case "Lauku skersiela":
                case "LAUKU SKERSIELA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\lauku_skersiela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.55486%2C27.72608#map=15/56.5489/27.7229&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "darzu skersiela":
                case "Darzu skersiela":
                case "DARZU SKERSIELA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\darzu_skersiela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54783%2C27.71705#map=16/56.5454/27.7180&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "ezera skersiela":
                case "Ezera skersiela":
                case "EZERA SKERSIELA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\ezera_skersiela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54280%2C27.71850%3B56.54760%2C27.72570#map=16/56.5452/27.7218&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "kraslavas skersiela":
                case "Kraslavas skersiela":
                case "KRASLAVAS SKERSIELA":
                    {
                        CustomMessageBox.Show("RUNTORTA    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\kraslavas_skersiela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54282%2C27.71850%3B56.53101%2C27.69580#map=15/56.5388/27.7074&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "latgales skersiela":
                case "Latgales skersiela":
                case "LATGALES SKERSIELA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\latgales_skersiela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5316%2C27.7363");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "liela ezerkrasta":
                case "Liela ezerkrasta":
                case "Liela Ezerkrasta":
                case "LIELA EZERKRASTA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\liela_skersiela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5482%2C27.7319");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "maza ezerkrasta":
                case "Maza ezerkrasta":
                case "Maza Ezerkrasta":
                case "MAZA EZERKRASTA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\maza_skersiela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5486%2C27.7170");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "stacijas skersiela":
                case "Stacijas skersiela":
                case "STACIJAS SKERSIELA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\stacijas_skersiela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5339%2C27.7216");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "stradnieku skersiela":
                case "Stradnieku skersiela":
                case "STRADNIEKU SKERSIELA":
                    {
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\stradnieku_skersiela.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.54725%2C27.72657#map=16/56.5451/27.7222&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "berzu":
                case "Berzu":
                case "BERZU":
                    {
                        CustomMessageBox.Show("Bērzu iela ir arī MAKAŠĀNOS(\"Dačas\")\n\nŠitais maršrūts priekš MARTIŠIEM");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\berzu.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.54287%2C27.71848%3B56.52633%2C27.74075#map=14/56.5354/27.7301&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "papardes":
                case "aizsargu":
                case "zvirgzdenes":
                case "meldru":
                case "zvirgzdenes skersiela":
                case "elejas":
                case "piekalna":
                case "dainas":
                case "cirulu":
                case "amolina":
                case "daliju":
                case "pipenu":
                case "darzinu":
                case "jasminu":
                case "kamenu":
                case "puku":
                case "ogu":
                case "abelu":
                case "zemnieku":
                case "jaunlejas":
                case "sukna":
                case "lejas":
                case "lejas skersiela":
                case "zvejnieku":
                case "torna":
                case "kirsu skersiela":
                case "kirsu":
                case "avotu":
                case "astras":
                case "piekrastes":
                case "kauguru":
                case "nelku":
                case "rozu":
                case "makasanu":
                case "piladzu":
                case "avenu":
                case "kalna":
                    {
                        CustomMessageBox.Show("\"MAKAŠĀNI\"(\"Dačas\") aiz \"Govju tilta\"");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\makasani.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5491%2C27.6970#map=16/56.5451/27.7080&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "kreici":
                    {
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5255%2C27.7681#map=14/56.5349/27.7434&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "buruski":
                    {
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5216%2C27.7110#map=14/56.5331/27.7238&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "zaci":
                    {
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5118%2C27.7067");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "evertova":
                    {
                        CustomMessageBox.Show("Netālu no Makašānu dačam aiz \"Govju tilta\"");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\evertova.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.5488%2C27.6905");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "ezerkrasts":
                    {
                        CustomMessageBox.Show("Netālu no Makašānu dačam aiz \"Govju tilta\"");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\ezerkrasts.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_foot&route=56.5429%2C27.7185%3B56.5513%2C27.6765#map=14/56.5457/27.6977&layers=P");
                        streetOrPlaceName.Focus();
                    }
                    break;

                case "berjozovka":
                case "berozovka":
                    {
                        CustomMessageBox.Show("Briģu pagasts    ");
                        Process.Start("chrome.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\Ciemi\berjozovka.png");
                        Process.Start("https://www.openstreetmap.org/directions?engine=fossgis_osrm_car&route=56.5429%2C27.7185%3B56.4583%2C27.9600#map=12/56.5011/27.8383&layers=P");
                    }
                    break;
                default:
                    {
                        CustomMessageBox.Show("TĀDAS IELAS VAI VIETAS NAV!\nPĀRBAUDIET PAREIZRAKSTĪBU!\n(NUMURUS VADĪT NEVAR!)");
                        streetOrPlaceName.Focus();
                    }
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Instrukcija_Click(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Ievadīt vajag tikai ielas vai vietas nosaukumu! Numurus rakstīt klāt nevar!\n\n" +
                "Programma rādīs ielu kura ir ievadīta divos veidos:\n" +
                "1. Karte ar maršrutu no daļas līdz vajadzīgas ielas tuvākajam krustojumam.\n" +
                "2. Karte ar ielas virzienu: sākās - zaļais karogs, beidzās(pēdējais numurs) - sarkanais karogs.\n" +
                "Garumzīmes un mīkstinājuma zīmes rakstīt nevajag(aizņem daudz laika).\n\n" +
                "Ievades piemērs:\nIevadam ielu \"latgales\" vai vietu \"evertova\"(atkal, ar mazajiem burtiem - ātrāk).\n" +
                "Pašu vārdu \"iela\" arī nerakstam, un spiežam divās reizes \"Enter\" vai " +
                "uzreiz ar peli noklikšķinam uz pogas \"Meklēt\"\r\nJa ir kāds papildus apraksts tas parādīsies uz ekrāna, " +
                "tad spiežam \"Enter\", ja nav tad uzreiz redzēsiet kartes.\r\nJa nepareizi ievadīti ielas vai vietas " +
                "nosaukums tad redzēsiet ziņojumu: \"Tādas ielas vai vietas nav! Pārbaudiet pareizrakstību.\"\r\n\n" +
                "Piemēri:\n Kr. Barona iela --> barona,\n 18. Novembra iela --> novembra,\n A. Jurdža iela --> jurdza,\n " +
                "1. maija iela --> maija,\n Ezerkrasts --> ezerkrasts,\n Makašāni --> makasani,\n Fr. Ķempa iela --> kempa,\n " +
                "Kuļņeva iela --> kulneva,\n Latgales šķērsiela --> latgales skersiela,\n Klusā iela --> klusa, utt.\r\n\n" +
                "Lūdzu apskatiet video pamācību.\n" +
                "Programma domāta tikai priekš Ludzas pilsētas un tās apkaimes.\n");

            streetOrPlaceName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextReader tr = new StreamReader("C:/Users/WinMac/source/repos/WindowsFormsApp1/Counter.txt");
            string countString = tr.ReadLine();
            counter = Convert.ToInt32(countString);
            tr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Вводить нужно только название улицы или места! Дописывать к ним номера нельзя!\n\n" +
                "Программа покажет улицу которая была введена в двух вариантах:\n" +
                "1. Карта с маршрутом от части до ближайшего перекрёстка нужной нам улицы.\n" +
                "2. Карта с направлением улуцы: начинается -  зеленый флажок, заканчивается(последний номер) - красный флажок.\n" +
                "Ударения и смягчители букв писать не нужно(занимает много времени).\n\nПример ввода:\nВводим улицу \"latgales\" " +
                "или место \"evertova\"(опять-же, с маленькой буквы - быстрее). Само слово \"iela\" так-же не пишем, и " +
                "нажимаем два раза \"Enter\"\nили сразу мышкой кликаем на кнопку \"Meklēt\"\r\nЕсли имеется какое-либо " +
                "дополнительное описание оно появится на экране, тогда нажимаем \"Enter\", если-же нет то сразу увидите карты.\r\n" +
                "Если неправильно введены название улицы или места тогда увидим сообщение: " +
                "\"Tādas ielas vai vietas nav! Pārbaudiet pareizrakstību.\"\n(Такой улицы или места нет! " +
                "Проверьте правописание.)\r\n\nПримеры:\n Kr. Barona iela --> barona,\n 18. Novembra iela --> novembra,\n " +
                "A. Jurdža iela --> jurdza,\n 1. maija iela --> maija,\n Ezerkrasts --> ezerkrasts,\n Makašāni --> makasani,\n " +
                "Fr. Ķempa iela --> kempa,\n Kuļņeva iela --> kulneva,\n Klusā iela --> klusa, итд.\r\n\n" +
                "Пожалуйста просмотрите видео руководство.\n" +
                "Программа предназначена только для города Лудза и окрестностей.\n");

            streetOrPlaceName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", @"C:\Users\WinMac\source\repos\WindowsFormsApp1\Rekomendacijas.txt.txt");
            streetOrPlaceName.Focus();
        }

        private void YouTube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youtu.be/ryOAw7oi0bw");
            streetOrPlaceName.Focus();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void streetOrPlaceName_ForeColorChanged(object sender, EventArgs e)
        {

        }
    }
    public class CustomMessageBox : Form
    {
        public CustomMessageBox(string message)
        {
            InitializeComponents(message);
        }

        private void InitializeComponents(string message)
        {
            this.Text = "Informācija";
            this.Size = new System.Drawing.Size(100, 100);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AutoSize = true;

            Label label = new Label();
            label.Text = message;
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(20, 20);
            label.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

            Size labelSize = TextRenderer.MeasureText(message, label.Font);
            label.Size = labelSize;

            this.Controls.Add(label);
            this.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    this.Close();
            };
        }

        public static void Show(string message)
        {
            using (CustomMessageBox customMessageBox = new CustomMessageBox(message))
            {
                customMessageBox.ShowDialog();
            }
        }

    }
}
