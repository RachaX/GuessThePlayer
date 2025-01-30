using GuessThePlayer.ViewModel;
using System.Windows;

namespace GuessThePlayer
{
    public partial class GameWindow : Window
    {
        private string _sport;
        private string _diff;
        public GameWindow(string sport, string difficulty, string gameMod)
        {
            _diff = difficulty;
            _sport = sport;
            this.DataContext = new PlayersViewModel(sport, difficulty, gameMod);
            Loaded += GameWindow_Loaded;
            InitializeComponent();
        }

        private async void GameWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as PlayersViewModel;
            
            await viewModel.InitializeAsync(this);
        }
    }
}
