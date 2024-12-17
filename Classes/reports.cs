using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Classes
{
    public class reports
    {
        public int ReportId { get; set; }
        public string ReportType { get; set; }
        public int GeneratedByUserId { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string ReportContent { get; set; }
    }
}
