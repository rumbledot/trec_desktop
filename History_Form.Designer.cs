
namespace TREC_Desktop
{
    partial class History_Form
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
                this.task_viewer.Dispose();
                this.task_viewer = null;

                this.dgv_Tasks.CellDoubleClick -= Dgv_Tasks_CellDoubleClick;

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
            this.calendar_History = new System.Windows.Forms.MonthCalendar();
            this.dgv_Tasks = new System.Windows.Forms.DataGridView();
            this.lbl_Selected_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Task_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar_History
            // 
            this.calendar_History.Location = new System.Drawing.Point(18, 18);
            this.calendar_History.MaxSelectionCount = 1;
            this.calendar_History.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.calendar_History.Name = "calendar_History";
            this.calendar_History.TabIndex = 0;
            this.calendar_History.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateClick);
            // 
            // dgv_Tasks
            // 
            this.dgv_Tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tasks.Location = new System.Drawing.Point(257, 18);
            this.dgv_Tasks.Name = "dgv_Tasks";
            this.dgv_Tasks.Size = new System.Drawing.Size(446, 420);
            this.dgv_Tasks.TabIndex = 1;
            // 
            // lbl_Selected_date
            // 
            this.lbl_Selected_date.AutoSize = true;
            this.lbl_Selected_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selected_date.Location = new System.Drawing.Point(13, 216);
            this.lbl_Selected_date.Name = "lbl_Selected_date";
            this.lbl_Selected_date.Size = new System.Drawing.Size(70, 25);
            this.lbl_Selected_date.TabIndex = 2;
            this.lbl_Selected_date.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Viewing";
            // 
            // lbl_Task_count
            // 
            this.lbl_Task_count.AutoSize = true;
            this.lbl_Task_count.Location = new System.Drawing.Point(15, 249);
            this.lbl_Task_count.Name = "lbl_Task_count";
            this.lbl_Task_count.Size = new System.Drawing.Size(43, 13);
            this.lbl_Task_count.TabIndex = 4;
            this.lbl_Task_count.Text = "Tasks#";
            // 
            // History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.lbl_Task_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Selected_date);
            this.Controls.Add(this.dgv_Tasks);
            this.Controls.Add(this.calendar_History);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "History_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar_History;
        private System.Windows.Forms.DataGridView dgv_Tasks;
        private System.Windows.Forms.Label lbl_Selected_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Task_count;
    }
}