using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace R3M.Enterprise.Models.Model
{
    [Table("GeneralSite")]
    public class GeneralSite
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Site Başlık")]
        [Required,StringLength(150,ErrorMessage = "150 karakter sınırı")]
        public string Title { get; set; }
        [DisplayName("Anahtar Kelimeler")]
        [Required, StringLength(250, ErrorMessage = "250 karakter sınırı")]
        public string Keywords { get; set; }
        [DisplayName("Site Açıklama")]
        [Required, StringLength(500, ErrorMessage = "500 karakter sınırı")]
        public string Description { get; set; }
        [DisplayName("Site Logo")]
        [Required, StringLength(250, ErrorMessage = "250 karakter sınırı")]
        public string LogoUrl { get; set; }
        [DisplayName("Site Ünvanı")]
        [Required, StringLength(250, ErrorMessage = "250 karakter sınırı")]
        public string Superscription { get; set; }
    }
}