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

namespace Project_WPM
{
    /// <summary>
    /// subwindow1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class subwindow1 : Window
    {
        public subwindow1()
        {
            InitializeComponent();
        }
        private void btn_easy_Click(object sender, RoutedEventArgs e)
        {
            subwindow1 sub1 = new subwindow1();
            subwindow2 sub2 = new subwindow2();
            sub2.Show();
            this.Close();

        }

        private void btn_normal_Click(object sender, RoutedEventArgs e)
        {
            subwindow1 sub1 = new subwindow1();
            subwindow3 sub3 = new subwindow3();
            sub3.Show();
            this.Close();
        }

        private void btn_hard_Click(object sender, RoutedEventArgs e)
        {
            subwindow1 sub1 = new subwindow1();
            subwindow4 sub4 = new subwindow4();
            sub4.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }


    }
}

