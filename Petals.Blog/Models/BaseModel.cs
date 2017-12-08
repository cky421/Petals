using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Petals.Blog.Models
{
    public class BaseModel
    {
        [DataType(DataType.DateTime)]
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdatedDateTime { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedDateTime { get; set; }

        [DataType(DataType.Text)]
        [StringLength(20)]
        [Required]
        public string CreatedOprName { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        public string CreatedOprID { get; set; }

        [DataType(DataType.Text)]
        [StringLength(20)]
        public string UpdatedOprName { get; set; }

        /// <summary>
        /// 更新者ID
        /// </summary>
        public string UpdatedOprID { get; set; }
    }

    public class SimpleBaseModel:BaseModel
    {
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
    }
}
