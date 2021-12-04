using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Entities
{
    [Table("tbl_contacts")]
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [StringLength(150, ErrorMessage = "Contact name too long!")]
        public string ContactName { get; set; }

        [ForeignKey("FK_CountryId")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        [ForeignKey("FK_CompanyId")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}
