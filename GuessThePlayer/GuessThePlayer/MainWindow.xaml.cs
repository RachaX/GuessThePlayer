using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace GuessThePlayer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            var sport = (sportCBox.SelectedItem as ComboBoxItem)?.Content as string;
            var diff = (diffCBox.SelectedItem as ComboBoxItem)?.Content as string;

            if(sport == null || diff == null)
            {
                MessageBox.Show("Molimo vas da izaberete sport i tezinu.", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            } 
            else
            {
                MessageBox.Show("Srecno!", "", MessageBoxButton.OK, MessageBoxImage.Information); 
                var game = new GameWindow(sport, diff, "Level");
                game.Show();

                this.Close();
            }

        }

        private void walkBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Srecno!", "", MessageBoxButton.OK, MessageBoxImage.Information);
            GameWindow game = new GameWindow("", "Easy", "Game");
            game.Show();

            this.Close();
        }
    }
}
