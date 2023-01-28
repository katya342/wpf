using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.lib
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }   
        public string Edition { get; set; }
        public string Isbn { get; set; }
        public int Page { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Pdf { get; set; }
    }
}
