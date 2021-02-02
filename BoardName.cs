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
    public partial class BoardName : Form
    {
        public static string name;

        public BoardName()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_boardName.Text != "")
            {
                name = txt_boardName.Text;
                this.Close();
            }
            else
                MessageBox.Show("The board name can't be empty!");
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
