using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int blog_ID { get; set; }
        public string blog_Name { get; set; }
        public string blog_Title { get; set; }
        public string blog_Content { get; set; }
        public string blog_image { get; set; }
        public DateTime blog_Date { get; set; }
    }
}
