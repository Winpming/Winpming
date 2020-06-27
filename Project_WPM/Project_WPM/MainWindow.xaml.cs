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

namespace Project_WPM
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            //MediaElement me = new MediaElement();
           
            //me.Source = new Uri("/./Resources/music/music_main.mp3", UriKind.Absolute);
            music.LoadedBehavior = MediaState.Manual;
            music.Play();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            subwindow1 sub = new subwindow1();
            sub.Show();
            this.Close();
        }
    }
}
