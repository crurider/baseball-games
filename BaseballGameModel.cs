using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGames {
    public class BaseballGameModel {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int GameId { get; set; }
        public int Pitches { get; set; }
        public bool Pro { get; set; }
        public bool Soft { get; set; }
        public double Amount { get; set; }
    }
}
