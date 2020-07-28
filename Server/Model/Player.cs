using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Player
    {
        public Socket tcpClient { get; set; }

        private int _countTrueQuestion;
        public int _iDPlayer { get; set; }
        public string _codePlayer { get; set; }
        public string _namePlayer { get; set; }

        public int CountTrueQuestion 
        {
            get { return _countTrueQuestion; }
            set
            {
                if( value < 0 || value > 10)
                {
                    _countTrueQuestion = 0; 
                }
                else
                {
                    _countTrueQuestion = value;
                }
            }
        }

        public Player(int IDPlayler , string CodePlayer,string NamePlayer , Socket tcpClient)
        {
            this._codePlayer = CodePlayer;
            this._namePlayer = NamePlayer;
            this._iDPlayer = IDPlayler;
            this.tcpClient = tcpClient;
            this._countTrueQuestion = 0;
        }
        

    }
}
