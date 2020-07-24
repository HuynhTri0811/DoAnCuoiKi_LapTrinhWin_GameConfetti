using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientCode : Form
    {
        public ClientCode()
        {
            InitializeComponent();
        }

        private void ClientCode_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
