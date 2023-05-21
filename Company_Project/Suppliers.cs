using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project
{
    internal class Suppliers
    {
        [Key]

        public int SupplierID { get; set; }

        [Required]
        public string SuppName { get; set; }

        public int Suppphone { get; set; }

        [Required, Column(TypeName = "varchar")]
        public string SuppFax { get; set; }

        [Required, Column(TypeName = "varchar"), MaxLength(200)]
        public string SuppEmail { get; set; }

        [Required]
        public string SuppWebsite { get; set; }
        public override string ToString()
        {
            return this.SuppName;
        }

        

        public virtual ICollection<Transfer_Items> Transfares { get; set; }

       
    }
}
