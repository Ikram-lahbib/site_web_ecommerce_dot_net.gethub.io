using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteBookTimeMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Writer { get; set; }
        public string Caterory { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Summary { get; set; }
    }
}
