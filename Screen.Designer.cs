
namespace KanbanSystem
{
    partial class Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Board = new System.Windows.Forms.Panel();
            this.flp_Done = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Done = new System.Windows.Forms.Label();
            this.flp_Doing = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Doing = new System.Windows.Forms.Label();
            this.flp_ToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_ToDo = new System.Windows.Forms.Label();
            this.btn_newTask = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Board.SuspendLayout();
            this.flp_Done.SuspendLayout();
            this.flp_Doing.SuspendLayout();
            this.flp_ToDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Board
            // 
            this.panel_Board.Controls.Add(this.flp_Done);
            this.panel_Board.Controls.Add(this.flp_Doing);
            this.panel_Board.Controls.Add(this.flp_ToDo);
            this.panel_Board.Controls.Add(this.lbl_Title);
            this.panel_Board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Board.Location = new System.Drawing.Point(0, 0);
            this.panel_Board.Name = "panel_Board";
            this.panel_Board.Size = new System.Drawing.Size(982, 753);
            this.panel_Board.TabIndex = 3;
            // 
            // flp_Done
            // 
            this.flp_Done.Controls.Add(this.lbl_Done);
            this.flp_Done.Location = new System.Drawing.Point(720, 70);
            this.flp_Done.Name = "flp_Done";
            this.flp_Done.Size = new System.Drawing.Size(250, 671);
            this.flp_Done.TabIndex = 3;
            // 
            // lbl_Done
            // 
            this.lbl_Done.AutoSize = true;
            this.lbl_Done.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Done.Location = new System.Drawing.Point(3, 0);
            this.lbl_Done.Name = "lbl_Done";
            this.lbl_Done.Size = new System.Drawing.Size(70, 25);
            this.lbl_Done.TabIndex = 2;
            this.lbl_Done.Text = "Done";
            this.lbl_Done.Click += new System.EventHandler(this.lbl_Done_Click);
            // 
            // flp_Doing
            // 
            this.flp_Doing.Controls.Add(this.lbl_Doing);
            this.flp_Doing.Location = new System.Drawing.Point(370, 70);
            this.flp_Doing.Name = "flp_Doing";
            this.flp_Doing.Size = new System.Drawing.Size(250, 671);
            this.flp_Doing.TabIndex = 2;
            // 
            // lbl_Doing
            // 
            this.lbl_Doing.AutoSize = true;
            this.lbl_Doing.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doing.Location = new System.Drawing.Point(3, 0);
            this.lbl_Doing.Name = "lbl_Doing";
            this.lbl_Doing.Size = new System.Drawing.Size(78, 25);
            this.lbl_Doing.TabIndex = 1;
            this.lbl_Doing.Text = "Doing";
            this.lbl_Doing.Click += new System.EventHandler(this.lbl_Doing_Click);
            // 
            // flp_ToDo
            // 
            this.flp_ToDo.Controls.Add(this.lbl_ToDo);
            this.flp_ToDo.Controls.Add(this.btn_newTask);
            this.flp_ToDo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_ToDo.Location = new System.Drawing.Point(12, 70);
            this.flp_ToDo.Name = "flp_ToDo";
            this.flp_ToDo.Size = new System.Drawing.Size(250, 671);
            this.flp_ToDo.TabIndex = 1;
            // 
            // lbl_ToDo
            // 
            this.lbl_ToDo.AutoSize = true;
            this.lbl_ToDo.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToDo.Location = new System.Drawing.Point(3, 0);
            this.lbl_ToDo.Name = "lbl_ToDo";
            this.lbl_ToDo.Size = new System.Drawing.Size(84, 25);
            this.lbl_ToDo.TabIndex = 0;
            this.lbl_ToDo.Text = "TO DO";
            this.lbl_ToDo.Click += new System.EventHandler(this.lbl_ToDo_Click);
            // 
            // btn_newTask
            // 
            this.btn_newTask.Location = new System.Drawing.Point(3, 28);
            this.btn_newTask.Name = "btn_newTask";
            this.btn_newTask.Size = new System.Drawing.Size(247, 42);
            this.btn_newTask.TabIndex = 1;
            this.btn_newTask.Text = "New Task";
            this.btn_newTask.UseVisualStyleBackColor = true;
            this.btn_newTask.Click += new System.EventHandler(this.btn_newTask_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(455, 15);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(72, 29);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Title";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panel_Board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanban System";
            this.panel_Board.ResumeLayout(false);
            this.panel_Board.PerformLayout();
            this.flp_Done.ResumeLayout(false);
            this.flp_Done.PerformLayout();
            this.flp_Doing.ResumeLayout(false);
            this.flp_Doing.PerformLayout();
            this.flp_ToDo.ResumeLayout(false);
            this.flp_ToDo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Board;
        private System.Windows.Forms.FlowLayoutPanel flp_Done;
        private System.Windows.Forms.FlowLayoutPanel flp_Doing;
        private System.Windows.Forms.FlowLayoutPanel flp_ToDo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_ToDo;
        private System.Windows.Forms.Label lbl_Done;
        private System.Windows.Forms.Label lbl_Doing;
        private System.Windows.Forms.Button btn_newTask;
    }
}

