using System;
using System.Windows.Forms;
using Service;

namespace WindowsFormsApplication
{
    public partial class LogInForm : Form
    {
        private ServiceController c;
        public LogInForm()
        {
            InitializeComponent();
            c = new ServiceController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (c.LogIn(tbLoginUsername.Text) != null)
            {
                Form MF = new MainForm(c.IsLoggedIn());
                this.Visible = false;
                MF.Show();    
            }
            else MessageBox.Show(string.Format("No match on username: {0}", tbLoginUsername.Text));
        }
    }
}
