using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project
{
    internal class Export_Permission
    {
        [Key]
      
        public int ExportCode { get; set; }

        [Column(TypeName ="date")]
        public DateTime ExportDate { get; set; }

        [ForeignKey("items")]
        public int ItemId { get; set; }
        public int ItemsCount { get; set; }
        public virtual Items items { get; set; }

        [ForeignKey("customers")]
        public int customerId { get; set; }
        public string customerName { get; set; }
        public virtual Customers customers { get; set; }

        [ForeignKey("store")]
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public virtual Store store { get; set; }


    }
}
