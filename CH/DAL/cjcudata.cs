using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CH.Models;

namespace CH.DAL
{
    public class cjcudata : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var books = new List<Books>
            {
            new Books{Bname ="Carson", Writer ="Alexander",Co ="123",Date=DateTime.Parse("2005-09-01")},
            new Books{Bname ="Carson1", Writer ="Alexander",Co ="123",Date=DateTime.Parse("2005-09-01")},
             new Books{Bname ="Carson2", Writer ="Alexander",Co ="123",Date=DateTime.Parse("2005-09-01")},
              new Books{Bname ="Carson3", Writer ="Alexander",Co ="123",Date=DateTime.Parse("2005-09-01")},
               new Books{Bname ="Carson4", Writer ="Alexander",Co ="123",Date=DateTime.Parse("2005-09-01")}

            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();
           
            var history = new List<History>
            {
            new History{Date=DateTime.Parse("2005-09-01"),Limit_time =DateTime.Parse("2005-09-01"),Action="借出"},
            new History{Date=DateTime.Parse("2005-09-01"),Limit_time =DateTime.Parse("2005-09-01"),Action="歸還"},

            };
            history.ForEach(s => context.History.Add(s));
            context.SaveChanges();
        }
    }
}