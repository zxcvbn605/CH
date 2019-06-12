using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CH.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string Bname { get; set; }
        public string Writer { get; set; }
        public string Co { get; set; }
        public DateTime Date { get; set; }


       
    }
}