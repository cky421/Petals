using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Petals.Blog.Models
{

    public class Author
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public ICollection<Blog> Blogs { get; set; }

        [Required]
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserID { get; set; }

        public User User { get; set; }

        [Required]
        /// <summary>
        /// 是否可用
        /// </summary>
        public bool IsLocked { get; set; }
        
        [StringLength(50)]
        /// <summary>
        /// 不可用原因
        /// </summary>
        public string LockedReason { get; set; }
    }
}
