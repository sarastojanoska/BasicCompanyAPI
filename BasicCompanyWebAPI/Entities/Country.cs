using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCompanyWebAPI.Entities
{
    [Table("tbl_countries")]
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [StringLength(150, ErrorMessage ="Country name too long!")]
        public string CountryName { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
