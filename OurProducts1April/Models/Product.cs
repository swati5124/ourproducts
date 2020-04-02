using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OurProducts1April.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int PId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Price { get; set; }

    }
}
