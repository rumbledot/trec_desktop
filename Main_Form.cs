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
        public Database_Connection connection;
        public Database_Instance database;
        public SQL_Datatable<TaskUnit> tasks;

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

            this.tasks = new SQL_Datatable<TaskUnit>(this.database);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btn_New":
                    this.task = new TaskUnit();
                    this.task.start = DateTime.Now;

                    break;
                case "btn_Save":
                    this.task.end = DateTime.Now;
                    this.task.narration = this.tbox_Task.Text.Trim();

                    this.tasks.Add(task);

                    this.tbox_Task.Text = "";

                    this.task = new TaskUnit();
                    this.task.start = DateTime.Now;

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
