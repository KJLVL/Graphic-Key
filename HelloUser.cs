using System.Windows.Forms;

namespace graphicKey
{
    public partial class HelloUser : Form
    {
        public HelloUser(string login)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            headerL.Text = "Добро пожаловать, " + login;
        }

        private void exitB_Click(object sender, System.EventArgs e)
        {
            Hide();
            Authorization a = new Authorization();
            a.Show();
        }
    }
}
