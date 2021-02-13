
namespace KanbanSystem
{
    partial class TaskMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskMenu));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_stateTODO = new System.Windows.Forms.Button();
            this.btn_stateDoing = new System.Windows.Forms.Button();
            this.btn_stateDone = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Change Task State";
            // 
            // btn_stateTODO
            // 
            this.btn_stateTODO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_stateTODO.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stateTODO.Location = new System.Drawing.Point(12, 47);
            this.btn_stateTODO.Name = "btn_stateTODO";
            this.btn_stateTODO.Size = new System.Drawing.Size(110, 43);
            this.btn_stateTODO.TabIndex = 8;
            this.btn_stateTODO.Text = "TO DO";
            this.btn_stateTODO.UseVisualStyleBackColor = true;
            this.btn_stateTODO.Click += new System.EventHandler(this.btn_stateTODO_Click);
            // 
            // btn_stateDoing
            // 
            this.btn_stateDoing.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_stateDoing.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stateDoing.Location = new System.Drawing.Point(186, 47);
            this.btn_stateDoing.Name = "btn_stateDoing";
            this.btn_stateDoing.Size = new System.Drawing.Size(110, 43);
            this.btn_stateDoing.TabIndex = 9;
            this.btn_stateDoing.Text = "Doing";
            this.btn_stateDoing.UseVisualStyleBackColor = true;
            this.btn_stateDoing.Click += new System.EventHandler(this.btn_stateDoing_Click);
            // 
            // btn_stateDone
            // 
            this.btn_stateDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_stateDone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stateDone.Location = new System.Drawing.Point(379, 47);
            this.btn_stateDone.Name = "btn_stateDone";
            this.btn_stateDone.Size = new System.Drawing.Size(110, 43);
            this.btn_stateDone.TabIndex = 10;
            this.btn_stateDone.Text = "Done";
            this.btn_stateDone.UseVisualStyleBackColor = true;
            this.btn_stateDone.Click += new System.EventHandler(this.btn_stateDone_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Remove.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(142, 255);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(216, 63);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.Text = "Remove Task";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // TaskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 330);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_stateDone);
            this.Controls.Add(this.btn_stateDoing);
            this.Controls.Add(this.btn_stateTODO);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_stateTODO;
        private System.Windows.Forms.Button btn_stateDoing;
        private System.Windows.Forms.Button btn_stateDone;
        private System.Windows.Forms.Button btn_Remove;
    }
}