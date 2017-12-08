using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Petals.Blog.Models
{
    public class Blog : BaseModel
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50)]
        /// <summary>
        /// 后面可以路由的Title
        /// </summary>
        public string NickTitle { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50)]
        [Required]
        [Display(Name = "文章标题",Description = "文章标题")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        [Display(Description = "文章内容")]
        public string Content { get; set; }

        [MaxLength(8)]
        [Display(Description = "阅读量")]
        /// <summary>
        /// 点击量
        /// </summary>
        public int HitCount { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Description = "概要内容")]
        /// <summary>
        /// 短内容
        /// </summary>
        public string ShortContent { get; set; }

        [DataType(DataType.ImageUrl)]
        public string PicUrl { get; set; }

        public ICollection<BlogTag> BlogTags { get; set; }
        public ICollection<BlogCategory> BlogCategories { get; set; }

        [DataType(DataType.Custom)]
        public ContentType ContentType { get; set; }

    }

    public enum ContentType
    {
        Markdown = 1,
        RichText = 2
    }

}
