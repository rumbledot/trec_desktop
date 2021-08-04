using DB_SQL_Library;
using DB_SQL_Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TREC_Desktop.Models;

namespace TREC_Desktop
{
    public partial class Main_Form : Form
    {
        private Database_Connection connection;
        private Database_Instance database;
        private SQL_Datatable<TaskUnit> tasks;

        private TaskUnit task;

        public Main_Form()
        {
            InitializeComponent();

            this.connection = new Database_Connection();
            connection.Server_Address = "ABRAMDESK";
            connection.Database_Name = "TREC";
            connection.Database_User_ID = "bram";
            connection.Unencrypted_Password = "12345678";

            this.database = new Database_Instance(this.connection);

            if (!this.database.TestConnection()) 
            {
                Application.Exit();
            }

            Global.connection = this.connection;

            this.tasks = new SQL_Datatable<TaskUnit>(this.database);
            this.tasks.Initialise();

            Global.tasks = this.tasks;

            this.btn_End.Enabled = false;
            this.tbox_Task.Enabled = false;

            this.FormClosed += Main_Form_FormClosed;
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.task != null)
            {
                this.task.end_at = DateTime.Now;
                this.task.narration = string.IsNullOrEmpty(this.tbox_Task.Text) ? "a new task" : this.tbox_Task.Text.Trim();

                this.tasks.Add(task);
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btn_New":
                    this.task = new TaskUnit();
                    this.task.start_at = DateTime.Now;

                    this.btn_New.Visible = false;
                    this.btn_Save.Visible = true;
                    this.tbox_Task.Enabled = true;
                    break;
                case "btn_Save":
                    this.task.end_at = DateTime.Now;
                    this.task.narration = string.IsNullOrEmpty(this.tbox_Task.Text) ? "a new task" : this.tbox_Task.Text.Trim();

                    this.tasks.Add(task);

                    this.tbox_Task.Text = "";

                    this.task = new TaskUnit();
                    this.task.start_at = DateTime.Now;

                    this.btn_Save.Enabled = false;
                    this.btn_End.Enabled = true;

                    break;
                case "btn_End":
                    this.task.end_at = DateTime.Now;
                    this.task.narration = string.IsNullOrEmpty(this.tbox_Task.Text) ? "a new task" : this.tbox_Task.Text.Trim();

                    this.tasks.Add(task);
                    this.tbox_Task.Text = "";

                    this.btn_Save.Enabled = true;
                    this.btn_End.Enabled = false;
                    break;
                case "btn_History":
                    using (History_Form history = new History_Form())
                    {
                        history.ShowDialog();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
