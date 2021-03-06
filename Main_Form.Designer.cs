
using System;

namespace TREC_Desktop
{
    partial class Main_Form
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
                this.tasks = null;
                this.task = null;

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
            this.tbox_Task = new System.Windows.Forms.TextBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_End = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_Task
            // 
            this.tbox_Task.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Task.Location = new System.Drawing.Point(12, 12);
            this.tbox_Task.Multiline = true;
            this.tbox_Task.Name = "tbox_Task";
            this.tbox_Task.Size = new System.Drawing.Size(231, 246);
            this.tbox_Task.TabIndex = 0;
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_New.Location = new System.Drawing.Point(6, 268);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "New Task";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_History
            // 
            this.btn_History.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_History.Location = new System.Drawing.Point(168, 268);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(75, 23);
            this.btn_History.TabIndex = 2;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_End
            // 
            this.btn_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_End.Location = new System.Drawing.Point(87, 268);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(75, 23);
            this.btn_End.TabIndex = 3;
            this.btn_End.Text = "End";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Save.Location = new System.Drawing.Point(6, 268);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 303);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.tbox_Task);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-REC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Task;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_End;
        private System.Windows.Forms.Button btn_Save;
    }
}

