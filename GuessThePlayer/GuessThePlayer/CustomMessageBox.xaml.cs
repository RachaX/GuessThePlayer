using GuessThePlayer.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace GuessThePlayer
{
    public partial class CustomMessageBox : Window, INotifyPropertyChanged
    {
        private string _title;
        private string _gameMode;
        private string _reach;
        private Dictionary<string,string> _data;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Titlee
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(); }
        }
        public string GameMode
        {
            get { return _gameMode; }
            set { _gameMode = value; }
        }
        public string Reach
        {
            get { return _reach; }
            set { _reach = value; }
        }
        public Dictionary<string,string> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public CustomMessageBox(Dictionary<string, string> wrongAnsw, string gameMode, string reach)
        {
            this.DataContext = this;
            this.Data = wrongAnsw;
            this._gameMode = gameMode;
            this._reach = reach;
            InitializeComponent();
            writeReport();
        }

        private void writeReport()
        {
            string corrections = "";
            int answers = 0;

            int numOfLevels = 0;

            if (_gameMode.Equals("Game"))
            {
                switch (_reach)
                {
                    case "Easy": Titlee = "Početnik"; answers = 5; break;
                    case "Normal": Titlee = "Amater"; answers = 10; break;
                    case "Hard": Titlee = "Profesionalac"; answers = 15; break;
                }
                numOfLevels = 15;
            }
            else
            {
                Titlee = "Igra završena!";
                answers = 5;
                numOfLevels = 5;
            }


            foreach(KeyValuePair<string, string> kvp in _data)
            {
                corrections += $"{kvp.Key}  -  {kvp.Value}\n";
            }

            Description.Text = $"Broj tačnih odgovora: " + (answers - _data.Count).ToString() + "/" + numOfLevels.ToString() + "\n";
            if (_data.Count > 0)
                Description.Text += "Greške:\n" + $"{corrections}";
            else
                Description.Text += "Nema grešaka!";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) 
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        }
    }
}
