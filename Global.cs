using DB_SQL_Library;
using DB_SQL_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TREC_Desktop.Models;

namespace TREC_Desktop
{
    public static class Global
    {
        public static Database_Connection connection = null;
        public static SQL_Datatable<TaskUnit> tasks = null;
    }
}
