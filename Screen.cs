using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanSystem
{
    public partial class Screen : Form
    {
        #region Variaveis
        Button task;
        public static int taskState = 0;
        public static bool removeTask = false;
        #endregion

        public Screen()
        {
            InitializeComponent();
        }

        private void btn_newTask_Click(object sender, EventArgs e)
        {
            task = new Button();
            new TaskName().ShowDialog();
            task.Text = TaskName.name;
            task.Size = new Size(247, 42);
            task.Click += Task_Click;
            flp_ToDo.Controls.Add(task);
        }

        private void Task_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            new TaskMenu().ShowDialog();
            button.Name = "btn_" + task.Text;

            if (taskState == 0)
                flp_ToDo.Controls.Add(button);
            else if (taskState == 1)
                flp_Doing.Controls.Add(button);
            else if (taskState == 2)
                flp_Done.Controls.Add(button);

            if(removeTask == true)
            {
                flp_ToDo.Controls.Remove(button);
                flp_Doing.Controls.Remove(button);
                flp_Done.Controls.Remove(button);
            }
        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {
            new BoardName().ShowDialog();
            lbl_Title.Text = BoardName.name;
        }

        private void lbl_ToDo_Click(object sender, EventArgs e)
        {
            new ListName().ShowDialog();
            lbl_ToDo.Text = ListName.name;
        }

        private void lbl_Doing_Click(object sender, EventArgs e)
        {
            new ListName().ShowDialog();
            lbl_Doing.Text = ListName.name;
        }

        private void lbl_Done_Click(object sender, EventArgs e)
        {
            new ListName().ShowDialog();
            lbl_Done.Text = ListName.name;
        }
    }
}
