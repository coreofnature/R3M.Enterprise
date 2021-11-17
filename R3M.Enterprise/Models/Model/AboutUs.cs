using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace R3M.Enterprise.Models.Model
{
    [Table("AboutUs")]
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }
        [Required][DisplayName("Hakkımızda açıklama")]
        public string Description{ get; set; }
    }
}