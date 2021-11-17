using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace R3M.Enterprise.Models.Model
{
    [Table("BlogCategory")]
    public class BlogCategory
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Kategori Başlık")]
        [Required, StringLength(50, ErrorMessage = "50 karakter sınırı")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklama")]
        [Required, StringLength(500, ErrorMessage = "500 karakter sınırı")]
        public string Description { get; set; }
        public ICollection<Blog> Blogs { get; set; }

    }
}