using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petals.Blog.Models
{
    public class User : IdentityUser
    {
        /// <summary>
        /// 是否是作者，作者身份可以写文章，否则只能看文章
        /// </summary>
        public bool IsAuthor { get; set; }

    }
}
