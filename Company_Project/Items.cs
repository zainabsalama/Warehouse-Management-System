using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project
{
    internal class Items
    {
        [Key]
      
        public int Code { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public string UOMeasure { get; set; }

       
        public int? StoreId { get; set; }

        public override string ToString()
        {
            return this.ItemName;
        }
        public virtual Store Store { get; set; }

        public virtual ICollection<Export_Permission>Exports { get; set; }

        public virtual ICollection<Transfer_Items>Transfares { get; set; }

        public virtual ICollection<Import_Permission>Imports { get; set; }
    }
}
