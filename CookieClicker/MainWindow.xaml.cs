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

namespace CookieClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _score = 0; // The user score

        public MainWindow()
        {
            InitializeComponent();
            UpdateScore();
        }


        private void UpdateScore()
        {
            SauronCounterLabel.Content = (Math.Floor(_score).ToString() + " RINGS");
        }

        private void Sauron_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _score += 1;
            SauronImage.Width = Column1.ActualWidth;
            UpdateScore();
        }
        private void Sauron_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SauronImage.Width = SauronImage.ActualWidth * 0.9;
        }
        private void SauronImage_MouseEnter(object sender, MouseEventArgs e)
        {
            SauronImage.Width = Column1.ActualWidth;
        }
    }
}
