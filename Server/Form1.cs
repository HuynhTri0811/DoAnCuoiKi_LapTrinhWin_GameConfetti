using Server.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class serverConfetti : Form
    {

        #region Variable
        List<Player> ListPlayersConnecting = new List<Player>()
        {
            new Player(0,"abc","abc"),
            new Player(0,"abc","abc")
        };
        #endregion


        public serverConfetti()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListPlayerConnect();
            lbCountListPlayerChange();
            
        }

        private void LoadListPlayerConnect()
        {
            
            if(ListPlayersConnecting.Count == 0)
            {
                return;
            }

            for(int i = 0; i < ListPlayersConnecting.Count; i++)
            {
                string[] row = { ListPlayersConnecting.ElementAt(0).NamePlayer, "0" };
                var listViewItem = new ListViewItem(row);
                listviewPlayerConnected.Items.Add(listViewItem);
            }

            
        }
        private void lbCountListPlayerChange()
        {
            
            if (ListPlayersConnecting.Count <= 0)
            {
                return;
            }
            else
            {
                lbCountListPlayer.Text = ListPlayersConnecting.Count.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListPlayersConnecting.Add(new Player(0, "abc", "acb"));
            LoadListPlayerConnect();
            lbCountListPlayerChange();
            
        }
    }
}
