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
using System.Windows.Threading;

namespace Beadando_KM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DateTime kezd;
        private DispatcherTimer tempido = new DispatcherTimer();


        public MainWindow()
        {
            InitializeComponent();
            tempido.Interval = TimeSpan.FromMilliseconds(1);
            tempido.Tick += TIKKELES;
        }

        private void TIKKELES(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - kezd;
            timer.Content = string.Format("{0:mm\\:ss\\:fff}", elapsed);
        }

        bool start = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            idok.Items.Clear();
            korok = 0;

            start = !start;
            if (start)
            {
                kezd = DateTime.Now;
                start_stop.Content = "STOP";
                tempido.Start();
            }
            else
            {
                start_stop.Content = "START";
                tempido.Stop();
                
            }
            //START/STOP
        }

        List<string> idok_list = new List<string>();
        int korok = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            korok++;
            idok_list.Add(Convert.ToString(timer.Content));
            idok.Items.Add(String.Format(Convert.ToString(korok)+". "+timer.Content));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Diagramm
            //Progressbar sáv diagramm
            //Ki kell választani a maximum időt az lessz a teljes egység és abból arányosan jön le a többi
            //első 10 lesz megjelenítva csak
        }


    }
}
