using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientResult : Form
    {
        #region Properties
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        List<string> listresult = new List<string>();
        string namePlayer = "";
        #endregion
        public ClientResult()
        {
            InitializeComponent();
        }

        public ClientResult(List<string> lsResult, string name)
        {
            InitializeComponent();
            this.listresult = lsResult;
            this.namePlayer = name;
        }

        private void LoadListView()
        {
            if (listresult.Count == 0)
            {
                ListViewItem item2 = new ListViewItem();
                item2.Text = "";
                item2.Font = new Font(listView1.Font, FontStyle.Bold);

                listView1.Items.Add(item2);
            }
            foreach (string item in listresult)
            {
                if (item != namePlayer)
                {
                    listView1.Items.Add(item);
                }
                else
                {
                    ListViewItem item2 = new ListViewItem();
                    item2.Text = item;
                    item2.Font = new Font(listView1.Font, FontStyle.Bold);

                    listView1.Items.Add(item2);
                }
            }
        }


        private void ClientResult_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        #region Move form
        private void ClientResult_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ClientResult_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ClientResult_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #region Event's of the Exit button
        /// <summary>
        /// Handle of the Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Show title of the Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int x = Cursor.Position.X - this.Location.X - btn.Location.X;
            int y = Cursor.Position.Y - this.Location.Y - btn.Location.Y;
            tooltipShowTitle.Show("Thoát", btn, new Point(x + 5, y + 25));
        }

        /// <summary>
        /// Hide title of the Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tooltipShowTitle.Hide(btn);
        }

        /// <summary>
        /// Draw X characters on the Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Paint(object sender, PaintEventArgs e)
        {
            btnExit.Text = "";
            GraphicsPath gp = new GraphicsPath();
            gp.Reset();
            gp.AddRectangle(new Rectangle(0, 0, 40, 40));
            gp.AddLine(new Point(0, 0), new Point(40, 40));
            gp.AddLine(new Point(0, 40), new Point(40, 0));

            e.Graphics.DrawPath(new Pen(Color.Black, 6), gp);
        }
        #endregion
    }
}
