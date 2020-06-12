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
            MediaElement me = new MediaElement();
           
            me.Source = new Uri("C:/Users/user/Desktop/윈도우즈 사진/music_main.mp3", UriKind.Absolute);
            me.LoadedBehavior = MediaState.Manual;
            me.Play();

        }

       

        private void start_Click(object sender, RoutedEventArgs e)
        {

            character_choose sub = new character_choose();
            sub.Show();
            main.Hide();
        }

     
        private void close_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
