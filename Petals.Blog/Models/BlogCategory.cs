using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Petals.Blog.Models
{
    public class BlogCategory
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int BlogID { get; set; }

        public int CategoryID { get; set; }

        public Blog Blog { get; set; }
        public Category Category { get; set; }
    }
}
