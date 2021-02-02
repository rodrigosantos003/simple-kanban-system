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
    public partial class TaskMenu : Form
    {
        public static string name;

        public TaskMenu()
        {
            InitializeComponent();
        }

        private void btn_stateTODO_Click(object sender, EventArgs e)
        {
            if(Screen.taskState == 1 || Screen.taskState == 2)
                Screen.taskState = 0;
        }

        private void btn_stateDoing_Click(object sender, EventArgs e)
        {
            if (Screen.taskState == 0 || Screen.taskState == 2)
                Screen.taskState = 1;
        }

        private void btn_stateDone_Click(object sender, EventArgs e)
        {
            if (Screen.taskState == 0 || Screen.taskState == 1)
                Screen.taskState = 2;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Screen.removeTask = true;
        }
    }
}
