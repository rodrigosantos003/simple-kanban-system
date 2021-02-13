using System;
using System.Windows.Forms;

namespace KanbanSystem
{
    public partial class ListName : Form
    {
        public static string name;

        public ListName()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_listName.Text != "")
            {
                name = txt_listName.Text;
                this.Close();
            }
            else
                MessageBox.Show("The name of the list can't be empty!");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            name = "New List";
            this.Close();
        }
    }
}
