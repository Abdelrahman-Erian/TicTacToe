using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Game
{
    internal class Player
    {
        private char Symbol;
        private string Name;

        public Player(char _symbol, string _name )
        {
            Symbol = _symbol;
            Name = _name;
        }
    public char getSymbol() { return Symbol; }
    public string getName() { return Name; }
    }
}
