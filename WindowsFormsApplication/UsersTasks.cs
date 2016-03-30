using System;
using System.Linq;
using System.Windows.Forms;
using Service;
using ClassLibrary;

namespace WindowsFormsApplication
{
    public partial class UsersTasks : UserControl
    {
        private static UsersTasks _instance;
        private ServiceController c;

        public static UsersTasks Instance
        {
            get
            {
               if (_instance == null) _instance = new UsersTasks();
                return _instance;
            }
        }
        public UsersTasks()
        {
            
            InitializeComponent();
            c = new ServiceController();
            UpdateContent();
        }

        public void UpdateContent()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = c.GetTasksClosest().ToList();
            HideColumns();
        }
        private void HideColumns()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            c.RemoveTask(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            UpdateContent();
        }

        private void btnScheduleTask_Click(object sender, EventArgs e)
        {
            UserTaskModel t = new UserTaskModel();
            t.TaskName = tbTitle.Text;
            t.Date = dtpWhen.Value;
            t.Where = tbLocation.Text;
            t.UserId = c.FindUserFromUsername(LoggedIn.Username).UserId;
            c.AddTask(t);
            UpdateContent();

        }

        public void emptyView()
        {
            dataGridView1.DataSource = null;
        }
    }
}
