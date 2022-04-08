using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace graphicKey
{
    public partial class Authorization : Form
    {
        private string login;
        private readonly string path = @"D:\university\3\2sem\inform_protect\lab6\users.txt";
        private readonly List<string> loginArr;
        private readonly List<int> password;
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            password = new List<int>();
            loginArr = new List<string>();
        }

        private void signInB_Click(object sender, System.EventArgs e)
        {
            login = LoginTB.Text;
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    while (sr.Peek() > -1)
                    {
                        string[] s = sr.ReadLine().Split(' ');
                        if (s[0].Equals(login))
                        {
                            loginArr.Add(s[0]);
                            for (int i = 1; i < s.Length - 1; i++)
                            {
                                password.Add(Convert.ToInt32(s[i]));
                            }
                            break;
                        }
                    }
                }
            }
            if (loginArr.Count != 0)
            {
                for (int i = 0; i < loginArr.Count; i++)
                {
                    if (loginArr[i] == login)
                    {
                        grKey gk = new grKey(LoginTB.Text, true, password);
                        gk.Show();
                        Hide();
                        break;
                    }
                    else if (i == loginArr.Count - 1)
                    {
                        errorL.Text = "Имя пользователя не найдено. Повторите попытку.";
                    }
                }
            }
            else
            {
                errorL.Text = "Имя пользователя не найдено. Повторите попытку.";
            }
        }

        private void RegistrB_Click(object sender, System.EventArgs e)
        {
            Hide();
            grKey gk = new grKey(LoginTB.Text, false, password);
            gk.Show();
        }
    }
}
