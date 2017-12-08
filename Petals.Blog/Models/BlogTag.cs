using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Petals.Blog.Models
{
    public class BlogTag
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        
        public int BlogID { get; set; }

        public int TagID { get; set; }

        public Blog Blog { get; set; }
        public Tag Tag { get; set; }
    }
}
