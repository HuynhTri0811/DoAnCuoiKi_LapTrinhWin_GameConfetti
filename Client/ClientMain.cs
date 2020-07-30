using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
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

        IPEndPoint iP;
        Socket client;
        string name_Client;
        int port;
        string answerChoose = "D";
        int iD;
        int correctAnswerNumber = 0;
        string[] dsNumber = new string[] { "0", "0", "0", "A"};
        Question question = new Question();
        bool checkSendAnswer = false;
        int timeAnswer = 15;
        int numberOfRightAnswer = 0;
        #endregion

        public ClientMain(string ip, int port_sv, string name)
        {
            InitializeComponent();
            listAnswerButton.Add(picboxAnswer1);
            listAnswerButton.Add(picboxAnswer2);
            listAnswerButton.Add(picboxAnswer3);

            port = port_sv;
            name_Client = name;
            iP = new IPEndPoint(IPAddress.Parse(ip), port);
            Connect_Server();
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

            timeChooseAnswer.Interval = 1000;
            Connect_Server();
        }

        #region Draw question and answers
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
            string text = @"" + question._contentQuestion;

            g.DrawString(text, new Font("Arial", 14), Brushes.Black, rect);
            pnQuestion.BackgroundImage = bmp;
            pnQuestion.BackColor = Color.White;
        }

        /// <summary>
        /// Draw the Answer on pictureBox
        /// </summary>
        private void Draw_Answer(string answer, PictureBox picbox)
        {
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
            string text = answer;
            int sizeFont = 10;
            g.DrawString(text, new Font("Arial", sizeFont), Brushes.Black, new PointF(5, (pbHEIGHT / 2) - (sizeFont / 2)));

            //Load bitmap in picturebox
            picbox.Image = bmp;
            picbox.BackColor = Color.White;
        }

        /// <summary>
        /// Draw the Correct Answer
        /// </summary>
        private void Draw_AnswerTrue(int sumNumberAnswer)
        {
            int i = 0;
            int pbComplete = 0;

            foreach (PictureBox item in listAnswerButton)
            {
                //Get picturebox dimension
                int pbWIDTH = item.Width;
                int pbHEIGHT = item.Height;

                //Rounded corner radius
                int rCircle = pbHEIGHT * 25 / 100;

                pbComplete = (int.Parse(dsNumber[i]) * 100) / sumNumberAnswer;

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
                if (item.Name.Substring(item.Name.Length) == "1")
                {
                    if(answerChoose == "A")
                    {
                        if (answerChoose == dsNumber[3])
                        {
                            g.FillPath(Brushes.SpringGreen, gp);
                            numberOfRightAnswer++;
                        }
                        else
                        {
                            g.FillPath(Brushes.Crimson, gp);
                        }
                    }
                    else if(dsNumber[3] == "A")
                    {
                        g.FillPath(Brushes.SpringGreen, gp);
                    }
                    else
                    {
                        g.FillPath(Brushes.Silver, gp);
                    }
                }
                else if (item.Name.Substring(item.Name.Length) == "2")
                {
                    if (answerChoose == "B")
                    {
                        if (answerChoose == dsNumber[3])
                        {
                            g.FillPath(Brushes.SpringGreen, gp);
                            numberOfRightAnswer++;
                        }
                        else
                        {
                            g.FillPath(Brushes.Crimson, gp);
                        }
                    }
                    else if (dsNumber[3] == "B")
                    {
                        g.FillPath(Brushes.SpringGreen, gp);
                    }
                    else
                    {
                        g.FillPath(Brushes.Silver, gp);
                    }
                }
                else
                {
                    if (answerChoose == "C")
                    {
                        if (answerChoose == dsNumber[3])
                        {
                            g.FillPath(Brushes.SpringGreen, gp);
                            numberOfRightAnswer++;
                        }
                        else
                        {
                            g.FillPath(Brushes.Crimson, gp);
                        }
                    }
                    else if (dsNumber[3] == "C")
                    {
                        g.FillPath(Brushes.SpringGreen, gp);
                    }
                    else
                    {
                        g.FillPath(Brushes.Silver, gp);
                    }
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
                string numberStr = dsNumber[i];
                string text = "";
                if (i == 0)
                {
                    text = question._a_Answer;
                }
                else if (i == 1)
                {
                    text = question._b_Answer;
                }
                else
                {
                    text = question._c_Answer;
                }
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
        #endregion

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

        #region Time answer and handle click answer
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
                if(checkSendAnswer == false)
                {
                    Send_Server(answerChoose);
                    answerChoose = "D";
                }  
                
                timeChooseAnswer.Stop();                
                return;
            }
            timeAnswer--;
            lbTime.Text = timeAnswer + " giây";
        }

        /// <summary>
        /// Click answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Answer_Click(object sender, EventArgs e)
        {
            PictureBox picbox = (PictureBox)sender;
            int i = int.Parse(picbox.Name.Substring(picbox.Name.Length)) - 1;
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
            string text = "";
            if (picbox.Name.Substring(picbox.Name.Length - 1) == "1")
            {
                text = question._a_Answer;
                answerChoose = "A";
                Send_Server(answerChoose);
                checkSendAnswer = true;
                answerChoose = "D";
            }
            else if (picbox.Name.Substring(picbox.Name.Length - 1) == "2")
            {
                text = question._b_Answer;
                answerChoose = "B";
                Send_Server(answerChoose);
                checkSendAnswer = true;
                answerChoose = "D";
            }
            else
            {
                text = question._c_Answer;
                answerChoose = "C";
                Send_Server(answerChoose);
                checkSendAnswer = true;
                answerChoose = "D";
            }

            int sizeFont = 10;
            g.DrawString(text, new Font("Arial", sizeFont), Brushes.Black, new PointF(5, (pbHEIGHT / 2) - (sizeFont / 2)));

            //Load bitmap in picturebox
            picbox.Image = bmp;
            picbox.BackColor = Color.DarkTurquoise;

            //Remove handle click after click a answer
            foreach(PictureBox item in listAnswerButton)
            {
                item.Click -= Answer_Click;
            }
        }
        #endregion

        #region Connect, send and receive from Server
        /// <summary>
        /// Tạo chuỗi byte để gửi qua Socket
        /// </summary>
        /// <returns></returns>
        byte[] Serialize_Client(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        /// <summary>
        /// Nhận chuỗi byte để đọc thông tin
        /// </summary>
        /// <returns></returns>
        object Deserialize_Client(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        /// <summary>
        /// Kết nối tới server
        /// </summary>
        void Connect_Server()
        {
            //Địa chỉ của server

            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(iP);
                Send_Server(name_Client);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến server", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive_Server);
            listen.IsBackground = true;
            listen.Start();
        }

        /// <summary>
        /// Đóng kết nối
        /// </summary>
        void CloseConnect()
        {
            client.Close();
        }

        /// <summary>
        /// Xử lý khi form đóng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnect();
        }

        /// <summary>
        /// Gửi tin nhắn
        /// </summary>
        void Send_Server(string text)
        {
            client.Send(Serialize_Client(text));
        }

        /// <summary>
        /// Nhận tin nhắn
        /// </summary>
        void Receive_Server()
        {
            try
            {
                while (true)
                {
                    //Tạo mảng byte nhận về thông tin 5MB
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize_Client(data);

                    if(message.Substring(0,2) == "id")
                    {
                        iD = int.Parse(message.Substring(2));
                    }
                    else if(message.Substring(0,2) == "qs")
                    {
                        question = ParseQuestion(message.Substring(2));
                        Draw_Question();
                        Draw_Answer(question._a_Answer, listAnswerButton[0]);
                        Draw_Answer(question._b_Answer, listAnswerButton[1]);
                        Draw_Answer(question._c_Answer, listAnswerButton[2]);
                        foreach(PictureBox item in listAnswerButton)
                        {
                            item.Click += Answer_Click;
                        }
                        timeAnswer = 15;
                        checkSendAnswer = false;
                        timeChooseAnswer.Start();
                    }
                    else if(message.Substring(0,2) == "as")
                    {
                        int start = 0;
                        int end = 0;
                        string text = message.Substring(2);

                        start = text.IndexOf("A") + 1;
                        end = text.IndexOf("B");
                        dsNumber[0] = text.Substring(start, end - start);

                        start = end + 1;
                        end = text.IndexOf("C");
                        dsNumber[1] = text.Substring(start, end - start);

                        start = end + 1;
                        end = text.Length - 1;
                        dsNumber[2] = text.Substring(start, end - start);

                        dsNumber[3] = text.Substring(text.Length - 1);

                        int totalNumberPlayer = 0;
                        for(int i=0; i <= 2; i++)
                        {
                            totalNumberPlayer += int.Parse(dsNumber[i]);
                        }
                        Draw_AnswerTrue(totalNumberPlayer);
                        lbTime.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra sự cố khi kết nối server hoặc server đã đóng!", "Thông báo");
                CloseConnect();
            }
        }

        private Question ParseQuestion(string data)
        {
            Question qs = new Question();
            int start = 0;
            int end = 0;

            for (int i = 2; i < data.IndexOf("A@"); i++)
            {
                string strsub = data.Substring(2, i - 1);
                int numsub = 0;
                int.TryParse(strsub, out numsub);
                if (numsub == 0)
                {
                    start = i;
                    qs.ID = int.Parse(data.Substring(2, i - 2));
                    break;
                }
            }

            end = data.IndexOf("A@");
            qs._contentQuestion = data.Substring(start, end - start);

            start = end + 2;
            end = data.IndexOf("B@");
            qs._a_Answer = data.Substring(start, end - start);

            start = end + 2;
            end = data.IndexOf("C@");
            qs._b_Answer = data.Substring(start, end - start);

            start = end + 2;
            end = data.Length;
            qs._c_Answer = data.Substring(start, end - start);

            return qs;
        }
        #endregion
    }
}
