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
using static Client.ClientMain;

namespace Client
{
    public partial class ClientCode : Form
    {
        #region Properties
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public SetID send;
        #endregion

        public ClientCode()
        {
            InitializeComponent();
        }

        public ClientCode(SetID sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void ClientCode_Load(object sender, EventArgs e)
        {
            #region Draw the register button
            int tbWidth = picboxGui.Width;
            int tbHeight = picboxGui.Height;

            int bankinhCircle = tbHeight / 2;

            Bitmap bm = new Bitmap(tbWidth, tbHeight);
            Graphics g = Graphics.FromImage(bm);
            //Clear graphics
            //g.Clear(Color.Transparent);

            GraphicsPath gpKhung = new GraphicsPath();
            gpKhung.Reset();
            //Left
            Rectangle rect1 = new Rectangle(0, tbHeight - (bankinhCircle * 2), (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect1, 90, 90);
            Rectangle rect2 = new Rectangle(0, 0, (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect2, 180, 90);
            //Top
            gpKhung.AddLine(new Point(0, 0), new Point(tbWidth - bankinhCircle, 0));
            //Right
            Rectangle rect3 = new Rectangle(tbWidth - (bankinhCircle * 2), 0, (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect3, 270, 90);
            Rectangle rect4 = new Rectangle(tbWidth - (bankinhCircle * 2), tbHeight - (bankinhCircle * 2), (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect4, 0, 90);
            //Bottom
            gpKhung.AddLine(new Point(0, tbHeight), new Point(tbWidth - bankinhCircle, tbHeight));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(Brushes.Gainsboro, gpKhung);

            string text = @"Đăng ký";
            int fontSize = 10;
            g.DrawString(text, new Font("Arial", fontSize), Brushes.Black, new PointF((tbWidth / 2) - 26, (tbHeight / 2) - 8));

            picboxGui.Image = bm;
            #endregion
            txtCodeClient.textbox.Select();
        }

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

        #region Move form
        private void ClientCode_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ClientCode_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ClientCode_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void picboxGui_Click(object sender, EventArgs e)
        {
            string id = txtCodeClient.Text;
            int idSend = 0;
            if(id != "")
            {
                if(id == "ID của bạn")
                {
                    MessageBox.Show("Bạn chưa nhập id!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    int.TryParse(id, out idSend);
                    if(idSend == 0)
                    {
                        MessageBox.Show("Vui lòng không nhập chữ!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        this.send(idSend);
                        this.Close();
                    }
                }
            } 
        }

        private void picboxGui_MouseHover(object sender, EventArgs e)
        {
            int tbWidth = picboxGui.Width;
            int tbHeight = picboxGui.Height;

            int bankinhCircle = tbHeight / 2;

            Bitmap bm = new Bitmap(tbWidth, tbHeight);
            Graphics g = Graphics.FromImage(bm);
            //Clear graphics
            //g.Clear(Color.Transparent);

            GraphicsPath gpKhung = new GraphicsPath();
            gpKhung.Reset();
            //Left
            Rectangle rect1 = new Rectangle(0, tbHeight - (bankinhCircle * 2), (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect1, 90, 90);
            Rectangle rect2 = new Rectangle(0, 0, (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect2, 180, 90);
            //Top
            gpKhung.AddLine(new Point(0, 0), new Point(tbWidth - bankinhCircle, 0));
            //Right
            Rectangle rect3 = new Rectangle(tbWidth - (bankinhCircle * 2), 0, (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect3, 270, 90);
            Rectangle rect4 = new Rectangle(tbWidth - (bankinhCircle * 2), tbHeight - (bankinhCircle * 2), (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect4, 0, 90);
            //Bottom
            gpKhung.AddLine(new Point(0, tbHeight), new Point(tbWidth - bankinhCircle, tbHeight));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(Brushes.YellowGreen, gpKhung);

            string text = @"Đăng ký";
            int fontSize = 10;
            g.DrawString(text, new Font("Arial", fontSize), Brushes.Black, new PointF((tbWidth / 2) - 26, (tbHeight / 2) - 8));

            picboxGui.Image = bm;
        }

        private void picboxGui_MouseLeave(object sender, EventArgs e)
        {
            int tbWidth = picboxGui.Width;
            int tbHeight = picboxGui.Height;

            int bankinhCircle = tbHeight / 2;

            Bitmap bm = new Bitmap(tbWidth, tbHeight);
            Graphics g = Graphics.FromImage(bm);
            //Clear graphics
            //g.Clear(Color.Transparent);

            GraphicsPath gpKhung = new GraphicsPath();
            gpKhung.Reset();
            //Left
            Rectangle rect1 = new Rectangle(0, tbHeight - (bankinhCircle * 2), (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect1, 90, 90);
            Rectangle rect2 = new Rectangle(0, 0, (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect2, 180, 90);
            //Top
            gpKhung.AddLine(new Point(0, 0), new Point(tbWidth - bankinhCircle, 0));
            //Right
            Rectangle rect3 = new Rectangle(tbWidth - (bankinhCircle * 2), 0, (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect3, 270, 90);
            Rectangle rect4 = new Rectangle(tbWidth - (bankinhCircle * 2), tbHeight - (bankinhCircle * 2), (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect4, 0, 90);
            //Bottom
            gpKhung.AddLine(new Point(0, tbHeight), new Point(tbWidth - bankinhCircle, tbHeight));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(Brushes.Gainsboro, gpKhung);

            string text = @"Đăng ký";
            int fontSize = 10;
            g.DrawString(text, new Font("Arial", fontSize), Brushes.Black, new PointF((tbWidth / 2) - 26, (tbHeight / 2) - 8));

            picboxGui.Image = bm;
        }
    }
}
