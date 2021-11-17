using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace R3M.Enterprise.Models.Model
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Adres")]
        [Required, StringLength(500, ErrorMessage = "500 karakter sınırı")]
        public string Address { get; set; }
        [DisplayName("Telefon Numarası")]
        [Required, StringLength(15, ErrorMessage = "15 karakter sınırı")]
        public string MobilePhone { get; set; }
        [DisplayName("Fax Numarası")]
        [StringLength(15, ErrorMessage = "15 karakter sınırı")]
        public string Fax { get; set; }
        [DisplayName("Email Adresi")]
        [Required, StringLength(50, ErrorMessage = "50 karakter sınırı")]
        public string Email { get; set; }
        [DisplayName("Facebook Adresi")]
        [StringLength(50, ErrorMessage = "50 karakter sınırı")]
        public string Facebook { get; set; }
        [DisplayName("Twitter Adresi")]
        [StringLength(50, ErrorMessage = "50 karakter sınırı")]
        public string Twitter { get; set; }
        [DisplayName("Instagram Adresi")]
        [StringLength(50, ErrorMessage = "50 karakter sınırı")]
        public string Instagram{ get; set; }


    }
}