using System;
using System.Windows.Forms;
using Service;

namespace WindowsFormsApplication
{
    public partial class MainForm : Form
    {
        private ServiceController c;
        public MainForm()
        {
            InitializeComponent();
            c = new ServiceController();
            
        }

        public MainForm(bool isLoggedIn)
        {
            InitializeComponent();
            panel.Controls.Clear();
            if (isLoggedIn) { UserTasksUserControl(); }
            else MessageBox.Show("You are not logged in");
            this.Text = LoggedIn.Username + "'s Task Manager";
            c = new ServiceController();
        }


        internal void UserTasksUserControl()
        {
            if (!panel.Controls.Contains(UsersTasks.Instance))
            {
                UsersTasks.Instance.UpdateContent();
                panel.Controls.Add(UsersTasks.Instance);
                UsersTasks.Instance.Dock = DockStyle.Fill;
                UsersTasks.Instance.BringToFront();
            }
            else UsersTasks.Instance.BringToFront();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            c.LogOut();
            UsersTasks.Instance.UpdateContent();
            LogInForm LIF = new LogInForm();
            this.Visible = false;
   
            LIF.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }
}
