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

namespace KLIKER1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long point = 110;
        static int click = 1;
        double sol_b1 = 10 + 10 * (30 + click * 0.2);
        double sol_b2 = 20 + 20 * (60 + click * 0.4);
        double sol_b3 = 30 + 30 * (90 + click * 0.6);
        double sol_b4 = 40 + 40 * (120 + click * 0.8);
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Update()
        {
            poi.Content = "Points:" + point;
            cli.Content = "Points for click:" + click;
            b1.Content = (sol_b1).ToString();
            b2.Content = (sol_b2).ToString();
            b3.Content = (sol_b3).ToString();
            b4.Content = (sol_b4).ToString();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            point += IncrPoint(point, click);
            Update();
        }

        public long IncrPoint(long point, int click)
        {
            return point += click;
        }


        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (Upgraded(point, 1))
            {
                point -= Convert.ToInt64(Math.Round(sol_b1));
                click = IncreaseClick(click, 1);
                Update();
                ChangeImage();
            }
        }


        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (Upgraded(point, 2))
            {
                point -= Convert.ToInt64(Math.Round(sol_b2));
                click = IncreaseClick(click, 2);
                Update();
                ChangeImage();
            }
        }


        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (Upgraded(point, 3))
            {
                point -= Convert.ToInt64(Math.Round(sol_b3));
                click = IncreaseClick(click, 3);
                Update();
                ChangeImage();
            }
        }



        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (Upgraded(point, 4))
            {
                point = DecPoint(point, 4);
                click = IncreaseClick(click, 4);
                Update();
                ChangeImage();
            }
        }

        public long DecPoint(long point, int BTN)
        {
            if (BTN == 1)
            {
                return point - Convert.ToInt64(Math.Round(sol_b1));
            }
            else if (BTN == 2)
            {
                return point - Convert.ToInt64(Math.Round(sol_b2));
            }
            else if (BTN == 3)
            {
                return point - Convert.ToInt64(Math.Round(sol_b3));
            }
            else
            {
                return point - Convert.ToInt64(Math.Round(sol_b4));
            }
        }

        public int IncreaseClick(int click, int BTN)
        {
            if (BTN == 1)
            {
                return click + 3;
            }
            else if (BTN == 2)
            {
                return click + 10;
            }
            else if (BTN == 3)
            {
                return click + 30;
            }
            else
            {
                return click + 60;
            }
        }

        public bool Upgraded(long point, int BTN)
        {
            if (BTN == 1)
            {
                if (point >= (sol_b1))
                {
                    return true;
                }
                return false;
            }
            else if (BTN == 2)
            {
                if (point >= (sol_b2))
                {
                    return true;
                }
                return false;
            }
            else if (BTN == 3)
            {
                if (point >= (sol_b3))
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (point >= (sol_b4))
                {
                    return true;
                }
                return false;
            }
        }

        private void ChangeImage()
        {
            if (click > 60)
            {
                romashki.Source = BitmapFrame.Create(new Uri(@"KARTINKI/romashki-tsvety-belye-romashka-lepestki-tsvetochnyi-fon-fon.jpg"));
            }
            else if (click > 30)
            {
                romashki.Source = BitmapFrame.Create(new Uri(@"KARTINKI/romashki-tsvety-belye-romashka-lepestki-tsvetochnyi-fon-fon.jpg"));
            }
            else if (click > 10)
            {
                romashki.Source = BitmapFrame.Create(new Uri(@"KARTINKI/romashki-tsvety-belye-romashka-lepestki-tsvetochnyi-fon-fon.jpg"));
            }
        }

        

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
