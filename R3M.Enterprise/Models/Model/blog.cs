using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace R3M.Enterprise.Models.Model
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public BlogCategory Category { get; set; }


        [DisplayName("Blog Başlık")]
        [Required, StringLength(250, ErrorMessage = "250 karakter sınırı")]
        public string Title { get; set; }
        [DisplayName("Blog İçerik")]
        [Required]
        public string Content { get; set; }
        [DisplayName("Blog Görsel")]
        [Required, StringLength(250, ErrorMessage = "250 karakter sınırı")]
        public string ImageUrl { get; set; }
    }
}