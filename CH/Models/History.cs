using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CH.Models
{
    public class History
    {
        public int HistoryID { get; set; }
        public DateTime Date { get; set; }

        public DateTime Limit_time { get; set; }

        public string Action { get; set; }

        public virtual ICollection<Books> Bid { get; set; }
    }


}

