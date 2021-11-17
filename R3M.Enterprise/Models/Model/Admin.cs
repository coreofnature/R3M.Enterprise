using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace R3M.Enterprise.Models.Model
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(50, ErrorMessage = "50 karakter sınırı")]
        public string Email { get; set; }
        [Required, StringLength(50, ErrorMessage = "50 karakter sınırı")]
        public string Password { get; set; }
        public string Authority { get; set; }
    }
}