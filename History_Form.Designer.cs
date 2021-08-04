
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar_History
            // 
            this.calendar_History.Location = new System.Drawing.Point(18, 18);
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
            // History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.dgv_Tasks);
            this.Controls.Add(this.calendar_History);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "History_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar_History;
        private System.Windows.Forms.DataGridView dgv_Tasks;
    }
}