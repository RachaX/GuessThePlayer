using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePlayer.Model
{
     class PlayerAnswer : ObservableObject
    {
		private bool? _isCorrect;

		public bool? IsCorrect
		{
			get { return _isCorrect; }
			set { _isCorrect = value; OnPropertyChanged(); }
		}
		public PlayerModel Player { get; set; }

		public PlayerAnswer(PlayerModel player)
		{
			this.Player = player;
		}
	}
}
