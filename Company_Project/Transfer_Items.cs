using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project
{
    internal class Transfer_Items
    {
        [Key]
        public int TransferItemId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ProductionDate { get; set; }

        public int Expiry { get; set; }

        public int SourceStore { get; set; }

        public int DestinationStore { get; set; }

        public virtual Store InStore { get; set; }

        public virtual Store OutStore { get; set; }

        [ForeignKey("suppliers")]
        public int SupplierId { get; set; }

        public virtual Suppliers suppliers { get; set; }


        [ForeignKey("items")]
        public int ItemId { get; set; }

        public virtual Items items { get; set; }

    }
}
