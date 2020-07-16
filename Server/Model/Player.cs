using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Player
    {
        public int IDPlayer { get; set; }
        public string CodePlayer { get; set; }
        public string NamePlayer { get; set; }
        
        public Player(int IDPlayler , string CodePlayer,string NamePlayer)
        {
            this.CodePlayer = CodePlayer;
            this.NamePlayer = NamePlayer;
            this.IDPlayer = IDPlayer;
        }
    
    }
}
