using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project
{
    internal class Import_Permission
    {
        [Key]
     
        public int ImportCode { get; set; }

        [Column(TypeName ="date")]
        public DateTime ImportDate { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Expiry { get; set; }

        [ForeignKey("items")]
        public int ItemId { get; set; }
        public int ItemsCount { get; set; }
        public virtual Items items { get; set; }


        [ForeignKey("suppliers")]
        public int supplierId { get; set; }
        public string supplierName { get; set; }
        public virtual Suppliers suppliers { get; set; }

        [ForeignKey("store")]
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public virtual Store store { get; set; }
   

    }
}
