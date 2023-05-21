using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project
{
    internal class Customers
    {
        [Key]
       
        public int CustomId { get; set; }

        [Required]
        public string CustomName { get; set; }

        public int Customphone { get; set; }

        [Required,Column(TypeName ="varchar")]
        public string CustomFax { get; set; }

        [Required,Column(TypeName ="varchar"),MaxLength(200)]
        public string CustomEmail { get; set; }

        [Required]
        public string CustomWebsite { get; set; }
        public override string ToString()
        {
            return this.CustomName;
        }

        public ICollection <Export_Permission>exports { get; set; }
    }
}
