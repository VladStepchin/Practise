using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EnterpriseCatalog.Models
{
    [Table("Enterprises")]
    public class Enterprises
    {
      
        public int Id { get; set; }
       
        public string Name { get; set; }
     
        public string Address { get; set; }

        public int Employeers { get; set; }

        public long Income { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }

        public IEnumerable<Workforces> Workforces { get; set; }
    }
}