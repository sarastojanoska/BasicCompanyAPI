using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Entities
{
    [Table("tbl_companies")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [StringLength(150, ErrorMessage = "Company name too long!")]
        public string CompanyName { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
