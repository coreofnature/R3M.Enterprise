using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace R3M.Enterprise.Models.Model
{
    [Table("Services")]
    public class Services
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Hizmetler Başlık")]
        [Required, StringLength(50, ErrorMessage = "50 karakter sınırı")]
        public string Title { get; set; }
        [DisplayName("Hizmetler Açıklama")]
        [StringLength(500, ErrorMessage = "500 karakter sınırı")]
        public string Description { get; set; }
        [DisplayName("Hizmetler Görsel")]
        [StringLength(500, ErrorMessage = "500 karakter sınırı")]
        public string ImageUrl { get; set; }
    }
}