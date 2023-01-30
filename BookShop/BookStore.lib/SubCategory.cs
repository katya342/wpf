using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.lib
{
    [Table("SubCategory")]
    public class SubCategory
    {
        [Key]
        public int SubId { get; set; }
        public int Parent_Id { get; set; }
        public string SubName { get; set;}
    }
}
