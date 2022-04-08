using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Rectangle = System.Drawing.Rectangle;

namespace graphicKey
{
    public partial class grKey : Form
    {
        private readonly GraphKey gk;
        private readonly string login;
        private readonly bool checkUser;
        private readonly List<int> password;
        private readonly List<Point> point;
        private readonly string path = @"D:\university\3\2sem\inform_protect\lab6\users.txt";
        //File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt"));
        public grKey(string login, bool checkUser, List<int> password)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, grKPanel, new object[] { true });
            this.login = login;
            this.checkUser = checkUser;

            if (checkUser)
            {
                this.password = new List<int>();
                foreach (int p in password)
                {
                    this.password.Add(p);
                }
                headerL.Text = "   Введите графический ключ\n   для входа в аккаунт";
            }
            else
            {
                headerL.Text = "Придумайте графический ключ\nдля входа в аккаунт";
            }            

            gk = new GraphKey();
            point = new List<Point>();
            generatePoint();
            grKPanel.Paint += grKPanel_Paint;
        }
        private void update(object sender, EventArgs e)
        {
            Invalidate();
            grKPanel.Paint += grKPanel_Paint;
        }

        private void grKPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            using (var pen = new Pen(Color.FromArgb(135, 255, 221), 5))
            for (int i = 1; i < gk.passedVertex.Count; i++)
            {
                var p1 = point[gk.passedVertex[i - 1]];
                p1.Offset(13, 13);
                var p2 = point[gk.passedVertex[i]];
                p2.Offset(13, 13);
                e.Graphics.DrawLine(pen, p1, p2);
            }

            for (int i = 0; i < gk.row * gk.col; i++)
            {
                e.Graphics.FillEllipse(gk.passedVertex.Contains(i) ? new SolidBrush(Color.FromArgb(12, 166, 122)) : new SolidBrush(Color.FromArgb(124, 112, 114)), new Rectangle(point[i], new Size(gk.VertexSize / 2, gk.VertexSize / 2)));
                e.Graphics.DrawEllipse(Pens.Gray, new Rectangle(point[i], new Size(gk.VertexSize / 2, gk.VertexSize / 2)));
            }
        }
        private void grKPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gk.passedVertex.Clear();
            }
        }
        private void grKPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            var i = checkPoint(e.Location);
            if (i >= 0 && !gk.passedVertex.Contains(i))
            {
                gk.passedVertex.Add(i);
                grKPanel.Refresh();
            }
        }
        private void generatePoint()
        {
            for (int i = 0; i < gk.row * gk.col; i++)
            {
                var x = i % gk.col * 70 + gk.VertexSize / 2;
                var y = i / gk.col * 70 + gk.VertexSize / 2;
                point.Add(new Point(x + 5, y - 17));
            }
        }
        private int checkPoint(Point point1)
        {
            for (int i = 0; i < gk.row * gk.col; i++)
            {
                var p = point[i];
                var dx = p.X - point1.X;
                var dy = p.Y - point1.Y;
                if (Math.Abs(dx) <= gk.VertexSize / 3 && Math.Abs(dy) <= gk.VertexSize / 3)
                {
                    return i;
                }
            }
            return -1;
        }

        private void grKPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (!checkUser)
            {
                if (gk.passedVertex.Count != 0)
                {
                    string inf = login + " ";
                    foreach (var i in gk.passedVertex)
                    {
                        inf += i + " ";
                    }
                    inf += "\n";
                    File.AppendAllText(path, inf);

                    smsL.Text = "Пароль был записан";
                    panel2.Visible = true;
                }
            }
            else
            {
                checkPassword();
            }
        }

        private void checkPassword()
        {
            if (gk.passedVertex.Count == password.Count)
            {
                string passUser = "";
                string passUserBack = "";
                int j = 0;
                for (int i = password.Count - 1; i >= 0; i--)
                {
                    passUser += password[j];
                    passUserBack += password[i];
                    j++;
                }

                string enteredPass = "";
                foreach (int p in gk.passedVertex)
                {
                    enteredPass += p.ToString();
                }

                if (enteredPass.Equals(passUser) || enteredPass.Equals(passUserBack))
                {
                    HelloUser hu = new HelloUser(login);
                    Hide();
                    hu.Show();
                    panel2.Visible = true;
                    smsL.Text = "Пароль был подтвержден";
                }
                else
                {
                    MessageBox.Show("Неверный пароль. Повторите попытку");
                }
            }
            else
            {
                MessageBox.Show("Неверный пароль. Повторите попытку");
            }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization a = new Authorization();
            a.Show();
        }
    }
}