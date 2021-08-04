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
using COMM_VL.Data;
using EXTND;
using EXTND.ViewControl;

namespace TREC_Desktop
{
    public partial class History_Form : Form
    {
        private DataTable tasks_dt;
        private ViewTask_Form task_viewer;

        public History_Form()
        {
            InitializeComponent();

            DataGridViewColumn col = new DataGridViewColumn();
            this.dgv_Tasks.Initialise();
            this.dgv_Tasks.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgv_Tasks.Columns.Add(col.NewColumn("id", "id").HiddenColumn());
            this.dgv_Tasks.Columns.Add(col.NewColumn("Start at", "start_at_string").AlignCenter().ColumnWidth(80));
            this.dgv_Tasks.Columns.Add(col.NewColumn("Description", "narration").AlignLeft().ColumnWidth(200, DataGridViewTriState.False, DataGridViewAutoSizeColumnMode.Fill));
            this.dgv_Tasks.Columns.Add(col.NewColumn("Elapse", "elapse_string").AlignCenter().ColumnWidth(120));

            this.dgv_Tasks.CellDoubleClick += Dgv_Tasks_CellDoubleClick;
            
            this.RefreshDataTable();

            this.calendar_History.MaxDate = DateTime.Now.AddDays(1);
            this.calendar_History.MinDate = DateTime.Now.AddYears(-2);

            this.task_viewer = new ViewTask_Form();

            this.LoadTaskUnits(DateTime.Now);

            this.RefreshDGV();
        }

        private void Dgv_Tasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgv_Tasks.DataSource is null || this.dgv_Tasks.Rows.Count <= 0 || e.RowIndex < 0) return;

            if (e.ColumnIndex == 2 && (this.dgv_Tasks.Rows[e.RowIndex].Cells[2].Value != DBNull.Value || this.dgv_Tasks.Rows[e.RowIndex].Cells[2].Value != null))
            {
                this.task_viewer.Display(this.dgv_Tasks.Rows[e.RowIndex].Cells[2].Value.ToString());
                this.task_viewer.ShowDialog();
            }
        }

        private void RefreshDataTable()
        {
            DataColumn data_col = new DataColumn();
            this.tasks_dt = new DataTable();
            this.tasks_dt.Columns.Add(data_col.NewIDColumn("id"));
            this.tasks_dt.Columns.Add(data_col.NewColumn("start_at_string", typeof(string)));
            this.tasks_dt.Columns.Add(data_col.NewColumn("narration", typeof(string)));
            this.tasks_dt.Columns.Add(data_col.NewColumn("elapse", typeof(int)));
            this.tasks_dt.Columns.Add(data_col.NewColumn("elapse_string", typeof(string)));
        }

        private void RefreshDGV()
        {
            if (this.tasks_dt is null || this.tasks_dt.Rows.Count <= 0) 
            {
                this.dgv_Tasks.ClearSelection();

                this.dgv_Tasks.DataSource = null;
                this.dgv_Tasks.Invalidate();

                return;
            }
            this.dgv_Tasks.ClearSelection();

            this.dgv_Tasks.DataSource = this.tasks_dt;
            this.dgv_Tasks.Invalidate();
        }

        private void LoadTaskUnits(DateTime today_date)
        {
            this.lbl_Selected_date.Text = today_date.ToString("dd MMM yyyy");

            DataTable res = Global.tasks.LoadAll($"end_at>'{today_date.ToString("yyyy-MM-dd")}' AND end_at<'{today_date.AddDays(1).ToString("yyyy-MM-dd")}'");

            if (res is null || res.Rows.Count <= 0)
            {
                this.tasks_dt = null;
                this.lbl_Task_count.Text = "No tasks";

                return;
            }

            this.RefreshDataTable();

            decimal hour = 0, min = 0, sec = 0;

            this.tasks_dt.Merge(res);

            this.tasks_dt.AsEnumerable()
                    .ToList()
                    .ForEach(row =>
                    {
                        row["start_at_string"] = row.Value<DateTime>("start_at").ToString("HH:mm");
                        row["narration"] = row["narration"].ToString();

                        sec = (decimal)(row.Value<DateTime>("end_at") - row.Value<DateTime>("start_at")).TotalMinutes;
                        hour = Math.Abs(Math.Floor(sec / 3600));
                        min = Math.Abs(Math.Floor(sec - (hour * 3600) / 60));

                        row["elapse"] = (int)sec;
                        row["elapse_String"] = $"{hour} hours - {min} min";
                    });

            int total_working_hours = this.tasks_dt.AsEnumerable()
                .ToList()
                .Sum(row => row.Value<int>("elapse"));

            this.lbl_Task_count.Text = $"Task count : {this.tasks_dt.Rows.Count.ToString()}\n{Math.Round(Convert.ToDouble(total_working_hours / 3600))} hours";
        }

        private void DateClick(object sender, DateRangeEventArgs e)
        {
            DateTime selected_Date = e.Start;

            this.LoadTaskUnits(selected_Date);

            this.RefreshDGV();
        }
    }
}
