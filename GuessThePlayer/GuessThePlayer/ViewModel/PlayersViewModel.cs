using GuessThePlayer.Command;
using GuessThePlayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace GuessThePlayer.ViewModel
{
    class PlayersViewModel : ObservableObject
    {
        private string _sport;
        private string _difficulty;
        private string _gameMod;

        public string Sport
        {
            get { return _sport; }
            set { _sport = value; OnPropertyChanged(nameof(Sport));  }
        }

        public string Difficulty
        {
            get { return _difficulty; }
            set { _difficulty = value; OnPropertyChanged(nameof(Difficulty)); }
        }

        public string GameMod
        {
            get { return _gameMod; }
            set { _gameMod = value; OnPropertyChanged(nameof(GameMod)); }
        }


        private List<PlayerModel> _players;

        private List<PlayerModel> _easyMode;
        private List<PlayerModel> _normalMode;
        private List<PlayerModel> _hardMode;

        private Window _currentWindow;
        private Random _random;
        public RelayCommand CheckAnswerCommand => new RelayCommand(CheckAnswer);

        private bool? _isCorrect = null;
        private int _iterationCount; 
        private const int MaxIterations = 5;
        public bool? IsCorrect
        {
            get { return _isCorrect; }
            set { _isCorrect = value; OnPropertyChanged(); }
        }

        public Dictionary<string, string> wrongAnswers = new Dictionary<string, string>();

        public PlayersViewModel()
        {

        }

        public PlayersViewModel(string sport, string difficulty, string gameMod)
        {
            this._sport = sport;
            this._difficulty = difficulty;
            _gameMod = gameMod;
        }

        public async Task InitializeAsync(Window window)
        {
            this._random = new Random();
            this._currentWindow = window;
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += OnTimerTick;
            if (this._gameMod.Equals("Game"))
            {
                this._sport = (_random.Next(2) == 1) ? "Football" : "Basketball";
                this._easyMode = await PlayerService.loadLevel(this._sport, "Easy");
                this._normalMode = await PlayerService.loadLevel(this._sport, "Normal");
                this._hardMode = await PlayerService.loadLevel(this._sport, "Hard");
                startNextLevel();
            }
            else
            {
                this._players = await PlayerService.loadLevel(this._sport, this._difficulty);
                startLevel();
            }
        }

        private PlayerModel _currentPlayer;

        public PlayerModel CurrentPlayer
        {
            get { return _currentPlayer; }
            set { _currentPlayer = value; }
        }

        private BitmapImage _image;

        public BitmapImage Image
        {
            get { return _image; }
            set { _image = value; OnPropertyChanged(nameof(Image)); }
        }

        private List<PlayerAnswer> _options;

        public List<PlayerAnswer> Options
        {
            get { return _options; }
            set { _options = value; OnPropertyChanged(); }
        }

        private DispatcherTimer _timer;
        private Timer _delayTimer;
        private int _remainingTime;
        private string _timeLeft;
        public string TimeLeft
        {
            get { return $"{_remainingTime}s"; }
            set { _timeLeft = value; OnPropertyChanged(); }
        }

        public DispatcherTimer Timer
        {
            get { return _timer; }
            set { _timer = value; OnPropertyChanged();  }
        }

        public void startLevel()
        {
            _iterationCount = 0;
            _remainingTime = 12;
            _timer.Start();
            selectPlayer();
        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            if (_remainingTime > 0)
            {
                _remainingTime--;
                OnPropertyChanged(nameof(TimeLeft));
            }
            else
            {
                _timer.Stop(); 
                OnDelayElapsed();
            }
        }

        public void selectPlayer()
        {
            var randomPlayers = _players.OrderBy(x => _random.Next(10)).Take(3).ToList();
            CurrentPlayer = randomPlayers[_random.Next(3)];

            Options = new List<PlayerAnswer>();
            foreach(PlayerModel p in randomPlayers)
            {
                Options.Add(new PlayerAnswer(p));
            }
            OnPropertyChanged(nameof(Options));

            Image = CurrentPlayer.ConvertBase64ToImage();

            Options.OrderBy(x => _random.Next(3)).ToList();

            _players.Remove(CurrentPlayer);
        }

        public void CheckAnswer(object parameter)
        {           
            PlayerAnswer selectedPlayer = parameter as PlayerAnswer;

            if (selectedPlayer.Player.Name.Equals(CurrentPlayer.Name))
            {
                selectedPlayer.IsCorrect = true;
            }
            else
            {
                selectedPlayer.IsCorrect = false;
                wrongAnswers.Add(CurrentPlayer.Name, selectedPlayer.Player.Name);
            }
            
            _timer.Stop();
            OnDelayElapsed();      
        }

        private void OnDelayElapsed()
        {    
            _delayTimer = new Timer(1000); 
            _delayTimer.Elapsed += (s, e) =>
            {
                _delayTimer.Stop(); 
                _delayTimer.Dispose();  

                _iterationCount++;

                if (_iterationCount >= MaxIterations)
                {
                    if (_gameMod.Equals("Level"))
                    {
                        EndGame(this.Difficulty);
                    }
                    else
                    {
                        switch(this.Difficulty)
                        {
                            case "Easy": this.Difficulty = "Normal"; startNextLevel(); break;
                            case "Normal": this.Difficulty = "Hard"; startNextLevel(); break;
                            case "Hard": EndGame("Hard"); break;
                        }
                    }
                    return;
                }

                selectPlayer();

                _remainingTime = 12;  
                OnPropertyChanged(nameof(TimeLeft));

                _timer.Start(); 
            };
            _delayTimer.Start();
        }

        public void startNextLevel()
        {
            if (this.Difficulty.Equals("Easy"))
            {
                _players = _easyMode;
                startLevel();
            }
            else if (this.Difficulty.Equals("Normal"))
            {
                if (this.wrongAnswers.Count < 2)
                {
                    _players = _normalMode;
                    startLevel();
                }
                else
                {
                    EndGame("Easy");
                }
            }
            else if (this.Difficulty.Equals("Hard"))
            {
                if (this.wrongAnswers.Count < 4)
                {
                    _players = _hardMode;
                    startLevel();
                }
                else
                {
                    EndGame("Normal");
                }
            }
        }

        private void EndGame(String Reach)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                CustomMessageBox cmb = new CustomMessageBox(wrongAnswers, GameMod, Reach);
                cmb.Show();
                this._currentWindow.Close();
            });
        }
    }
            
}
