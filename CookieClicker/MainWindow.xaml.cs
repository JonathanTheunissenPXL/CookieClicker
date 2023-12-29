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

namespace CookieClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _score = 0; // The user score
        private double _totalScore = 0; // User total score
        private int _userClicks = 0; // How many times the user clicked
        private double _multiplier = 1.15; // Multiplier set at 15%

        List<Button> _buttonsList; // 1 on 1 relation with _valueButtonsList and _countButtonsList
        List<double> _valueButtonsList = new List<double> { 15, 100, 1100, 12000, 130000, 1400000, 20000000, 50000000, 100000000  ,250000000000, 500000000000 }; // Value of purchases
        List<int> _countButtonsClicksList = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // Number of purchases
        List<double> _revenueValueList = new List<double> { 0.1, 1, 8, 47, 260, 1400, 7800, 15600, 37500, 50000, 100000 }; //Revenue of purchases


        public MainWindow()
        {
            InitializeComponent();
            _buttonsList = new List<Button> { ringButton, wargButton, orcButton, urukhaiButton, trollButton, mumakilButton, balrogButton, nazgulButton, witchkingButton, sarumanButton, sauronButton }; // Purchases buttons
            UpdateScore();

            // Initializing the purchases buttons
            for (int index = 0; index < _buttonsList.Count; index++)
            {
                _buttonsList[index].Content = $"??? - {Math.Ceiling(_valueButtonsList[_buttonsList.IndexOf(_buttonsList[index])])}";
            }

            // Updating the mainwindow title every 1 second with the user score
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromSeconds(0.1);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {

            for (int index = 0; index < _valueButtonsList.Count; index++)
            {
                _score += _revenueValueList[index] * _countButtonsClicksList[index];
                _totalScore += _revenueValueList[index] * _countButtonsClicksList[index];
                if (_totalScore >= _valueButtonsList[index])
                {
                    UpdateButton(_buttonsList[index]);
                }
            }
            this.Title = Math.Floor(_score).ToString();
            UpdateScore();
        }
        private void Sauron_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _userClicks++;
            _score += 1;
            _totalScore += 1;
            SauronImage.Width = Column1.ActualWidth;
            CheckBalance();
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
        private void CheckBalance()
        {
            for (int index = 0; index < _buttonsList.Count; index++)
            {
                if (_score >= _valueButtonsList[index] && _buttonsList[index] != nazgulButton && _buttonsList[index] != witchkingButton
                        && _buttonsList[index] != sarumanButton && _buttonsList[index] != sauronButton)
                {
                    _buttonsList[index].IsEnabled = true;
                }
                else if (_buttonsList[index] == nazgulButton && _countButtonsClicksList[_buttonsList.IndexOf(balrogButton)] >= 7) // Check that the user has 7 Balrogs in order to unlock Nazgul
                {
                    _buttonsList[index].IsEnabled = true;
                }
                else if (_buttonsList[index] == witchkingButton && _countButtonsClicksList[_buttonsList.IndexOf(nazgulButton)] >= (_countButtonsClicksList[_buttonsList.IndexOf(witchkingButton)] + 1) * 8) // Check that the user has 8 nazgul to unlock wichking and after that for each 8 nazgul he can unlock a wichking
                {
                    _buttonsList[index].IsEnabled = true;
                }
                else if (_buttonsList[index] == sarumanButton && _userClicks >= 500) // Check if the user has 500 clicks to unlock saruman
                {
                    _buttonsList[index].IsEnabled = true;
                }
                else if (_buttonsList[index] == sauronButton && _userClicks >= 1000 && (_countButtonsClicksList[_buttonsList.IndexOf(witchkingButton)] > _countButtonsClicksList[_buttonsList.IndexOf(sauronButton)])) //Check if the user has 1000 clicks to unlock saruman and bought a witchking
                {
                    _buttonsList[index].IsEnabled = true;
                }
                else
                {
                    _buttonsList[index].IsEnabled = false;
                }
            }
        }

        private void ringButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(ringButton)];
            _valueButtonsList[_buttonsList.IndexOf(ringButton)] *= _multiplier;

            UpdateCounter(ringButton);
            UpdateButton(ringButton);
            CheckBalance();
            UpdateScore();
        }

        private void wargButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(wargButton)];
            _valueButtonsList[_buttonsList.IndexOf(wargButton)] *= _multiplier;

            UpdateCounter(wargButton);
            UpdateButton(wargButton);
            CheckBalance();
            UpdateScore();
        }

        private void orcButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(orcButton)];
            _valueButtonsList[_buttonsList.IndexOf(orcButton)] *= _multiplier;

            UpdateCounter(orcButton);
            UpdateButton(orcButton);
            CheckBalance();
            UpdateScore();
        }

        private void urukhaiButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(urukhaiButton)];
            _valueButtonsList[_buttonsList.IndexOf(urukhaiButton)] *= _multiplier;

            UpdateCounter(urukhaiButton);
            UpdateButton(urukhaiButton);
            CheckBalance();
            UpdateScore();
        }

        private void trollButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(trollButton)];
            _valueButtonsList[_buttonsList.IndexOf(trollButton)] *= _multiplier;

            UpdateCounter(trollButton);
            UpdateButton(trollButton);
            CheckBalance();
            UpdateScore();
        }

        private void mumakilButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(mumakilButton)];
            _valueButtonsList[_buttonsList.IndexOf(mumakilButton)] *= _multiplier;

            UpdateCounter(mumakilButton);
            UpdateButton(mumakilButton);
            CheckBalance();
            UpdateScore();
        }

        private void balrogButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(balrogButton)];
            _valueButtonsList[_buttonsList.IndexOf(balrogButton)] *= _multiplier;

            UpdateCounter(balrogButton);
            UpdateButton(balrogButton);
            CheckBalance();
            UpdateScore();
        }

        private void nazgulButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(nazgulButton)];
            _valueButtonsList[_buttonsList.IndexOf(nazgulButton)] *= _multiplier;

            UpdateCounter(nazgulButton);
            UpdateButton(nazgulButton);
            CheckBalance();
            UpdateScore();
        }

        private void witchkingButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(witchkingButton)];
            _valueButtonsList[_buttonsList.IndexOf(witchkingButton)] *= _multiplier;

            UpdateCounter(witchkingButton);
            UpdateButton(witchkingButton);
            CheckBalance();
            UpdateScore();
        }

        private void sarumanButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(sarumanButton)];
            _valueButtonsList[_buttonsList.IndexOf(sarumanButton)] *= _multiplier;

            UpdateCounter(sarumanButton);
            UpdateButton(sarumanButton);
            CheckBalance();
            UpdateScore();
        }

        private void sauronButton_Click(object sender, RoutedEventArgs e)
        {
            _score -= _valueButtonsList[_buttonsList.IndexOf(sauronButton)];
            _valueButtonsList[_buttonsList.IndexOf(sauronButton)] *= _multiplier;

            UpdateCounter(sauronButton);
            UpdateButton(sauronButton);
            CheckBalance();
            UpdateScore();
        }


        private void UpdateScore()
        {
            SauronCounterLabel.Content = (Math.Floor(_score).ToString() + " RINGS");
        }
        private void UpdateButton(Button button)
        {
            int indexButton = button.Name.IndexOf("Button");
            button.Content = $"{button.Name.Substring(0, indexButton)} \r\n Cost: {Math.Ceiling(_valueButtonsList[_buttonsList.IndexOf(button)])} \r\n Nr:{_countButtonsClicksList[_buttonsList.IndexOf(button)]}";
        }

        private void UpdateCounter(Button button)
        {
            _countButtonsClicksList[_buttonsList.IndexOf(button)]++;
        }
    }
}
