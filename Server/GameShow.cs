﻿using Model;
using Server.Model;
using Server.ReadFile;
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
        
        List<Player> ListPlayersConnecting = new List<Player>();
        List<Question> questionsData = new List<Question>();
        #endregion


        public serverConfetti(List<Question> questions)
        {
            InitializeComponent();
            this.questionsData = questions;
            LoadIDQuestion();
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

            listviewPlayerConnected.Columns.Add("Họ tên người chơi",100);
            listviewPlayerConnected.Columns.Add("Số câu đúng",70);
            
            for (int i = 0; i < ListPlayersConnecting.Count; i++)
            {

                string[] row = { ListPlayersConnecting.ElementAt(0)._namePlayer, "/"+"10" };
                
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


        private void LoadIDQuestion()
        {
            foreach(Question question in questionsData)
            {
                comboxLoadIDCauHoi.Items.Add(question.ID.ToString());
            }
            comboxLoadIDCauHoi.SelectedIndex = 0;
        }
        
        private void LoadQuestion()
        {
            Hello
        }
    }
}
