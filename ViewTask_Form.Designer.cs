
namespace TREC_Desktop
{
    partial class ViewTask_Form
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
            this.tbox_Narration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_Narration
            // 
            this.tbox_Narration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Narration.Location = new System.Drawing.Point(12, 12);
            this.tbox_Narration.Multiline = true;
            this.tbox_Narration.Name = "tbox_Narration";
            this.tbox_Narration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_Narration.Size = new System.Drawing.Size(413, 312);
            this.tbox_Narration.TabIndex = 0;
            // 
            // ViewTask_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 336);
            this.Controls.Add(this.tbox_Narration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewTask_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_Narration;
    }
}