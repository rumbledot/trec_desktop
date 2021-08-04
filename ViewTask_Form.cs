using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TREC_Desktop
{
    public partial class ViewTask_Form : Form
    {
        public ViewTask_Form()
        {
            InitializeComponent();
            this.tbox_Narration.ReadOnly = true;
        }

        public void Display(string text) 
        {
            this.tbox_Narration.Text = text;
        }
    }
}
