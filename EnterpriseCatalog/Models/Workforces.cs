using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseCatalog.Models
{
    public class Workforces
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
     
        public string Surname { get; set; }

        public string Position { get; set; }

        public int Experience { get; set; }

        public int Salary  { get; set; }

        public int EnterprisesId { get; set; }

        public Enterprises Enterprises { get; set; }
    }
}