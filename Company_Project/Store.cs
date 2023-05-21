using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project
{
    internal class Store
    {
        
        public int Id { get; set; }

        public string CompName { get; set; }

        [Column(TypeName ="varchar"),MaxLength(100)]
        public string Location { get; set; }

        
        public string CompManager { get; set; }
        public override string ToString()
        {
            return this.CompName;
        }

        public virtual ICollection<Items> items { get; set; }

        public virtual ICollection<Export_Permission>Exports { get; set; }
        public virtual ICollection<Import_Permission> Imports { get; set; }

        public virtual ICollection<Transfer_Items> ItemsOut { get; set; }
        public virtual ICollection<Transfer_Items> ItemsIn { get; set; }

    }
}
