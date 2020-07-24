using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientMain : Form
    {
        #region Properties
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        List<PictureBox> listAnswerButton = new List<PictureBox>();
        #region Test content
        string[] dsAnswers = new string[] { "Bằng răng", "Bằng bờm", "Bằng guốc" };
        int[] dsNumberAnswer = new int[] { 10, 30, 60 };
        int timeAnswer = 15;
        #endregion
        #endregion

        public ClientMain()
        {
            InitializeComponent();
            listAnswerButton.Add(picboxAnswer1);
            listAnswerButton.Add(picboxAnswer2);
            listAnswerButton.Add(picboxAnswer3);
        }        

        private void ClientMain_Load(object sender, EventArgs e)
        {
            #region Draw the frame of the tnlpnQuestion and change backcolor of tblpnAnswer
            int tbWidth = tblpnQuestion.Width;
            int tbHeight = tblpnQuestion.Height;

            int bankinhCircle = tbHeight * 20 / 100;

            Bitmap bm = new Bitmap(tbWidth, tbHeight);
            Graphics g = Graphics.FromImage(bm);
            //Clear graphics
            g.Clear(Color.Transparent);

            GraphicsPath gpKhung = new GraphicsPath();
            gpKhung.Reset();
            //Left
            Rectangle rect1 = new Rectangle(0, tbHeight - (bankinhCircle * 2), (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect1, 90, 90);
            gpKhung.AddLine(new Point(0, bankinhCircle), new Point(0, tbHeight - bankinhCircle));
            Rectangle rect2 = new Rectangle(0, 0, (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect2, 180, 90);
            //Top
            gpKhung.AddLine(new Point(0, 0), new Point(tbWidth - bankinhCircle, 0));
            //Right
            Rectangle rect3 = new Rectangle(tbWidth - (bankinhCircle * 2), 0, (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect3, 270, 90);
            gpKhung.AddLine(new Point(tbWidth, bankinhCircle), new Point(tbWidth, tbHeight - bankinhCircle));
            Rectangle rect4 = new Rectangle(tbWidth - (bankinhCircle * 2), tbHeight - (bankinhCircle * 2), (bankinhCircle * 2), (bankinhCircle * 2));
            gpKhung.AddArc(rect4, 0, 90);
            //Bottom
            gpKhung.AddLine(new Point(0, tbHeight), new Point(tbWidth - bankinhCircle, tbHeight));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(Brushes.White, gpKhung);

            tblpnQuestion.BackgroundImage = bm;

            tplpnAnswer.BackColor = Color.Transparent;
            #endregion

            Draw_Question();
            Draw_Answer();

            timeChooseAnswer.Start();
            this.picboxAnswer1.Click += Answer_Click;
            this.picboxAnswer2.Click += Answer_Click;
            this.picboxAnswer3.Click += Answer_Click;
        }

        /// <summary>
        /// Draw the Question on panel
        /// </summary>
        private void Draw_Question()
        {
            int pnQWidth = pnQuestion.Width;
            int pnQHeight = pnQuestion.Height;
            Rectangle rect = new Rectangle(0, 0, pnQWidth, pnQHeight);
            Bitmap bmp = new Bitmap(pnQWidth, pnQHeight);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.Transparent);
            g.FillRectangle(Brushes.White, rect);
            string text = @"Người ta có thể tính tuổi của một con ngựa một cách gần đúng nhất dù không biết ngày sinh là dựa vào bộ phận nào của ngựa?";

            g.DrawString(text, new Font("Arial", 14), Brushes.Black, rect);
            pnQuestion.BackgroundImage = bmp;
            pnQuestion.BackColor = Color.White;
        }

        /// <summary>
        /// Draw the Answer on pictureBox
        /// </summary>
        private void Draw_Answer()
        {
            int i = 0;
            foreach (PictureBox item in listAnswerButton)
            {
                //Get picturebox dimension
                int pbWIDTH = item.Width;
                int pbHEIGHT = item.Height;

                //Rounded corner radius
                int rCircle = pbHEIGHT * 25 / 100;

                Bitmap bmp = new Bitmap(pbWIDTH, pbHEIGHT);
                Graphics g = Graphics.FromImage(bmp);
                //Clear graphics
                g.Clear(Color.Transparent);


                #region Draw frame
                GraphicsPath gp = new GraphicsPath();
                gp.Reset();
                //Left
                Rectangle rect11 = new Rectangle(0, pbHEIGHT - (rCircle * 2), (rCircle * 2), (rCircle * 2));
                gp.AddArc(rect11, 90, 90);
                gp.AddLine(new Point(0, rCircle), new Point(0, pbHEIGHT - rCircle));
                Rectangle rect21 = new Rectangle(0, 0, (rCircle * 2), (rCircle * 2));
                gp.AddArc(rect21, 180, 90);
                //Top
                gp.AddLine(new Point(0, 0), new Point(pbWIDTH - rCircle, 0));
                //Right
                Rectangle rectRUK = new Rectangle(pbWIDTH - (rCircle * 2), 0, (rCircle * 2), (rCircle * 2));
                gp.AddArc(rectRUK, 270, 90);
                gp.AddLine(new Point(pbWIDTH, rCircle), new Point(pbWIDTH, pbHEIGHT - rCircle));
                Rectangle rectRBK = new Rectangle(pbWIDTH - (rCircle * 2), pbHEIGHT - (rCircle * 2), (rCircle * 2), (rCircle * 2));
                gp.AddArc(rectRBK, 0, 90);
                //Bottom
                gp.AddLine(new Point(0, pbHEIGHT), new Point(pbWIDTH - rCircle, pbHEIGHT));
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPath(Brushes.Gainsboro, gp);
                #endregion

                //Draw the answer
                string text = dsAnswers[i];
                int sizeFont = 10;
                g.DrawString(text, new Font("Arial", sizeFont), Brushes.Black, new PointF( 5, (pbHEIGHT / 2) - (sizeFont / 2)));

                //Load bitmap in picturebox
                item.Image = bmp;
                item.BackColor = Color.White;
                i++;
            }
        }

        /// <summary>
        /// Draw the Correct Answer
        /// </summary>
        private void Draw_AnswerTrue()
        {
            int sumNumberAnswer = 0;
            int pbComplete = 0;
            int i = 0;
            foreach (int item in dsNumberAnswer)
            {
                sumNumberAnswer += item;
            }
            foreach (PictureBox item in listAnswerButton)
            {
                //Get picturebox dimension
                int pbWIDTH = item.Width;
                int pbHEIGHT = item.Height;

                //Rounded corner radius
                int rCircle = pbHEIGHT * 25 / 100;

                pbComplete = (dsNumberAnswer[i] * 100) / sumNumberAnswer;

                Bitmap bmp = new Bitmap(pbWIDTH, pbHEIGHT);
                Graphics g = Graphics.FromImage(bmp);
                //Clear graphics
                g.Clear(Color.Transparent);

                #region Draw frame
                GraphicsPath gpKhung = new GraphicsPath();
                gpKhung.Reset();
                //Left
                Rectangle rect11 = new Rectangle(0, pbHEIGHT - (rCircle * 2), (rCircle * 2), (rCircle * 2));
                gpKhung.AddArc(rect11, 90, 90);
                gpKhung.AddLine(new Point(0, rCircle), new Point(0, pbHEIGHT - rCircle));
                Rectangle rect21 = new Rectangle(0, 0, (rCircle * 2), (rCircle * 2));
                gpKhung.AddArc(rect21, 180, 90);
                //Top
                gpKhung.AddLine(new Point(0, 0), new Point(pbWIDTH - rCircle, 0));
                //Right
                Rectangle rectRUK = new Rectangle(pbWIDTH - (rCircle * 2), 0, (rCircle * 2), (rCircle * 2));
                gpKhung.AddArc(rectRUK, 270, 90);
                gpKhung.AddLine(new Point(pbWIDTH, rCircle), new Point(pbWIDTH, pbHEIGHT - rCircle));
                Rectangle rectRBK = new Rectangle(pbWIDTH - (rCircle * 2), pbHEIGHT - (rCircle * 2), (rCircle * 2), (rCircle * 2));
                gpKhung.AddArc(rectRBK, 0, 90);
                //Bottom
                gpKhung.AddLine(new Point(0, pbHEIGHT), new Point(pbWIDTH - rCircle, pbHEIGHT));
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPath(Brushes.Gainsboro, gpKhung);
                #endregion


                #region Draw as a percentage inside
                GraphicsPath gp = new GraphicsPath();
                gp.Reset();
                //Left
                Rectangle rect1 = new Rectangle(0, pbHEIGHT - (rCircle * 2), (rCircle * 2), (rCircle * 2));
                gp.AddArc(rect1, 90, 90);
                gp.AddLine(new Point(0, rCircle), new Point(0, pbHEIGHT - rCircle));
                Rectangle rect2 = new Rectangle(0, 0, (rCircle * 2), (rCircle * 2));
                gp.AddArc(rect2, 180, 90);
                //Top
                gp.AddLine(new Point(0, 0), new Point((pbComplete * pbWIDTH / 100) - rCircle, 0));
                //Right
                Rectangle rectRU = new Rectangle((pbComplete * pbWIDTH / 100) - (rCircle * 2), 0, (rCircle * 2), (rCircle * 2));
                gp.AddArc(rectRU, 270, 90);
                gp.AddLine(new Point((pbComplete * pbWIDTH / 100), rCircle), new Point((pbComplete * pbWIDTH / 100), pbHEIGHT - rCircle));
                Rectangle rectRB = new Rectangle((pbComplete * pbWIDTH / 100 - (rCircle * 2)), pbHEIGHT - (rCircle * 2), (rCircle * 2), (rCircle * 2));
                gp.AddArc(rectRB, 0, 90);
                //Bottom
                gp.AddLine(new Point(0, pbHEIGHT), new Point((pbComplete * pbWIDTH / 100) - rCircle, pbHEIGHT));
                g.SmoothingMode = SmoothingMode.AntiAlias;

                //Choose color for the answer
                if (i == 0)
                {
                    g.FillPath(Brushes.SpringGreen, gp);
                }
                else if (i == 1)
                {
                    g.FillPath(Brushes.Crimson, gp);
                }
                else
                {
                    g.FillPath(Brushes.Silver, gp);
                }

                if (rCircle * 2 > (pbComplete * pbWIDTH / 100))
                {
                    GraphicsPath gpKhungChe = new GraphicsPath();
                    gpKhungChe.Reset();
                    gpKhungChe.AddLine(new Point(-2, pbHEIGHT + 2), new Point(-2, -2));
                    gpKhungChe.AddLine(new Point(-2, -2), new Point(rCircle, -2));
                    Rectangle rectKCU = new Rectangle(0, 0, (rCircle * 2), (rCircle * 2));
                    gpKhungChe.AddArc(rectKCU, 270, -90);
                    gpKhungChe.AddLine(new Point(0, rCircle), new Point(0, pbHEIGHT - rCircle));
                    Rectangle rectKCB = new Rectangle(0, pbHEIGHT - (rCircle * 2), (rCircle * 2), (rCircle * 2));
                    gpKhungChe.AddArc(rectKCB, 180, -90);
                    gpKhungChe.AddLine(new Point(rCircle, pbHEIGHT + 2), new Point(-2, pbHEIGHT + 2));
                    g.FillPath(Brushes.White, gpKhungChe);
                }


                //Draw the answer and number player answer
                string numberStr = dsNumberAnswer[i].ToString();
                string text = dsAnswers[i];
                int sizeFont = 10;
                g.DrawString(numberStr, new Font("Arial", sizeFont), Brushes.Black, new PointF(pbWIDTH - 30, (pbHEIGHT / 2) - (sizeFont / 2)));
                g.DrawString(text, new Font("Arial", sizeFont), Brushes.Black, new PointF( 5, (pbHEIGHT / 2) - (sizeFont / 2)));
                #endregion

                //Load bitmap in picturebox
                item.Image = bmp;
                pbComplete = 0;
                i++;
            }
        }

        #region Move Form
        private void ClientMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ClientMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ClientMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #region btnExit's Events
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

        /// <summary>
        /// Handle of the Exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion

        /// <summary>
        /// Time of answer the question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeChooseAnswer_Tick(object sender, EventArgs e)
        {
            if(timeAnswer < 1)
            {
                lbTime.Text = "Hết giờ";
                Draw_AnswerTrue();
                timeChooseAnswer.Stop();
                return;
            }
            timeAnswer--;
            lbTime.Text = timeAnswer + " giây";
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            PictureBox picbox = (PictureBox)sender;
            int i = int.Parse(picbox.Name.Substring(12)) - 1;
            //Get picturebox dimension
            int pbWIDTH = picbox.Width;
            int pbHEIGHT = picbox.Height;

            //Rounded corner radius
            int rCircle = pbHEIGHT * 25 / 100;

            Bitmap bmp = new Bitmap(pbWIDTH, pbHEIGHT);
            Graphics g = Graphics.FromImage(bmp);
            //Clear graphics
            g.Clear(Color.Transparent);

            #region Draw frame
            GraphicsPath gp = new GraphicsPath();
            gp.Reset();
            //Left
            gp.AddLine(new Point(0, pbHEIGHT), new Point(0, 0));
            //Top
            gp.AddLine(new Point(0, 0), new Point(pbWIDTH - rCircle, 0));
            //Right
            Rectangle rectRUK = new Rectangle(pbWIDTH - (rCircle * 2), 0, (rCircle * 2), (rCircle * 2));
            gp.AddArc(rectRUK, 270, 90);
            gp.AddLine(new Point(pbWIDTH, rCircle), new Point(pbWIDTH, pbHEIGHT - rCircle));
            Rectangle rectRBK = new Rectangle(pbWIDTH - (rCircle * 2), pbHEIGHT - (rCircle * 2), (rCircle * 2), (rCircle * 2));
            gp.AddArc(rectRBK, 0, 90);
            //Bottom
            gp.AddLine(new Point(0, pbHEIGHT), new Point(pbWIDTH - rCircle, pbHEIGHT));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(Brushes.HotPink, gp);
            #endregion

            //Draw the answer
            string text = dsAnswers[i];
            int sizeFont = 10;
            g.DrawString(text, new Font("Arial", sizeFont), Brushes.Black, new PointF(5, (pbHEIGHT / 2) - (sizeFont / 2)));

            //Load bitmap in picturebox
            picbox.Image = bmp;
            picbox.BackColor = Color.DarkTurquoise;
            this.picboxAnswer1.Click -= Answer_Click;
            this.picboxAnswer2.Click -= Answer_Click;
            this.picboxAnswer3.Click -= Answer_Click;
        }
    }
}
