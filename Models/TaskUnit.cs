using DB_SQL_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREC_Desktop.Models
{
    public class TaskUnit
    {
        [SQL_Primary_Key()]
        [SQL_Column()]
        public int id { get; set; }

        [SQL_Column("(1000)", "")]
        public string narration { get; set; }

        [SQL_Column()]
        public DateTime start { get; set; }

        [SQL_Column()]
        public DateTime end { get; set; }

        public int elapse 
        { 
            get 
            {
                return (this.end - this.start).Minutes;
            } 
        }
    }
}
