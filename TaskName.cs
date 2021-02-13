using System;
using System.Windows.Forms;

namespace KanbanSystem
{
    public partial class TaskName : Form
    {
        public static string name;

        public TaskName()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_taskName.Text != "")
            {
                name = txt_taskName.Text;
                this.Close();
            }
            else
                MessageBox.Show("The task name can't be empty!");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
