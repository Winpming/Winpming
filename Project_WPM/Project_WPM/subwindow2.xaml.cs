using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Project_WPM
{
    /// <summary>
    /// subwindow2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class subwindow2 : Window, INotifyPropertyChanged
    {
        Button first;
        Button second;
        private string count = "10";
        bool isStop = false;

        private string matched;
        public string Matched      // 남은 카드개수를 데이터 바인딩 하기 위한 Property
        {
            get
            {
                return matched;
            }
            set
            {
                matched = value;
                OnPropertyChanged("Matched");
            }
        }

        public string Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                OnPropertyChanged("Count");
                if (Int32.Parse(count) <= 0)
                {
                    tmr.Stop();
                    MessageBoxResult res = MessageBox.Show(
                         "실패!! 다시 하시겠습니까?", "Success", MessageBoxButton.YesNo);
                    if (res == MessageBoxResult.Yes)
                    {
                        resetRnd();
                        boardReset();
                        btnSet();
                        Matched = "16";

                        first = null;
                        second = null;
                        count = 10.ToString();
                        tmr.Start();
                    }
                    else
                    {
                        subwindow1 sub1 = new subwindow1();
                        sub1.Show();
                        this.Close();
                        tmr.Stop();
                    }

                }
            }
        }

        System.Windows.Threading.DispatcherTimer tmr = new System.Windows.Threading.DispatcherTimer();


        public subwindow2()
        {
            InitializeComponent();
            btnSet();               //버튼을 세팅하는 메소드
            tmr.Interval = new TimeSpan(0, 0, 1);
            tmr.Tick += new EventHandler(tmr_Tick);
            this.DataContext = this;
            tmr.Start();
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            Count = (Int32.Parse(count) - 1).ToString();
            label1.Content = Count;
        }

        private void btnSet()
        {
            Matched = "16";

            for (int i = 0; i < 16; i++)
            {
                Button btn = new Button();
                btn.Background = Brushes.White;
                btn.Margin = new Thickness(5);
                btn.Tag = TagSet();         //맞는 그림을 선택했는지 확인하기 위한 Tag를 설정하는 메소드
                btn.Content = MakeImage("/Resources/Images/" + btn.Tag + ".png");
                btn.Click += btn_Click;
                gameBoard.Children.Add(btn);
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)        //버튼 클릭시 이벤트
        {
            Button btn = sender as Button;

            if (first == null)         // 첫번째 버튼이 아직 눌러지지 않았으면 눌린 버튼을첫번째 버튼으로 설정
            {
                first = btn;
                btn.Opacity = 0.5;
                btn.IsEnabled = false;
                return;
            }
            else if (second == null)   // 첫번째 버튼이 눌렸고 두번째 버튼이 아직 눌려지지 않았을때 두번째 버튼을 누르면 두번째 버튼으로 설정 
            {
                second = btn;
                btn.Opacity = 0.5;
                btn.IsEnabled = false;
            }
            else   // 이미 두개의 버튼이 열렸는데 3번째 버튼을 눌렀을 경우, 아무 일 안하고 리턴
                return;

            // 매치가 되었을 때
            if ((int)first.Tag == (int)second.Tag)  // 버튼의 Tag Property가 같다면
            {
                Button btn1 = first;
                Button btn2 = second;
                btn1.Opacity = 0.0;
                btn2.Opacity = 0.0;

                first = null;
                second = null;

                Matched = (Int32.Parse(Matched) - 2).ToString();   //맞춘 회수를 증가

                if (Int32.Parse(Matched) <= 0)
                {
                    tmr.Stop();
                    MessageBoxResult res = MessageBox.Show(
                         "성공! 다시 하시겠습니까?", "Success", MessageBoxButton.YesNo);
                    if (res == MessageBoxResult.Yes)
                    {
                        resetRnd();
                        boardReset();
                        btnSet();
                        Matched = "16";
                    }
                }
            }
            // 매치가 안되었을 때
            else
            {
                Button btn1 = first;
                Button btn2 = second;
                btn1.Opacity = 1.0;
                btn1.IsEnabled = true;
                btn2.Opacity = 1.0;
                btn2.IsEnabled = true;

                first = null;
                second = null;
            }
        }

        // 게임 재시작시 초기화
        private void boardReset()           //버튼 
        {
            gameBoard.Children.Clear();
        }

        private void resetRnd()             // rnd[] 배열 초기화
        {
            for (int i = 0; i < 16; i++)
                randint[i] = 0;
        }

        private Image MakeImage(string r)   //파일을 불러서 버튼 이미지를 설정
        {
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri(r, UriKind.Relative);
            bit.EndInit();

            Image myImage = new Image();
            myImage.Margin = new Thickness(5);
            myImage.Stretch = Stretch.Fill;
            myImage.Source = bit;

            return myImage;
        }

        int[] randint = new int[16];

        private int TagSet()    // 0~7사이 정수를 만들어 리턴하는 함수. 중복되지 않도록 한쌍에 2개씩 숫자를 랜덤으로 생성한다.
        {
            int i;
            Random rand = new Random();
            while (true)
            {
                i = rand.Next(16); // 0~15까지
                if (randint[i] == 0)
                {
                    randint[i] = 1;
                    break;
                }
            }
            return i % 8; // 태그는 0~7까지, 8개의 그림을 표시
        }

        //남은 카드(Matched)변수를 xaml과 데이터바인딩하기 위한 INotifyPropertyChanged인터페이스 구현
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyScore)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyScore));
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            subwindow1 sub1 = new subwindow1();
            sub1.Show();
            this.Close();
            tmr.Stop();
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            if (isStop == false)
            {
                tmr.Stop();
                for (int i = 0; i < 16; i++)
                {
                    Button btn = gameBoard.Children[i] as Button;
                    btn.IsEnabled = false;
                }
                isStop = true;
            }
            else
            {
                tmr.Start();
                for (int i = 0; i < 16; i++)
                {
                    Button btn = gameBoard.Children[i] as Button;
                    btn.IsEnabled = true;
                }
                isStop = false;
            }
        }
    }


}
