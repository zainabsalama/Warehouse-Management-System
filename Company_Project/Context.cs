using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Project
{
    internal class Context:DbContext
    {
        public  Context() :base(@"Data Source=DESKTOP-KDUQ7QQ;Initial Catalog=Company_Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;")
            { }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }

        public virtual DbSet<Items>Items { get; set; }

        public virtual DbSet<Suppliers> Suppliers { get; set; }

        public virtual DbSet<Import_Permission> Imports { get; set; }
        public virtual DbSet<Export_Permission> Exports { get; set; }

        public virtual DbSet<Transfer_Items> Transactions { get; set; }
    }
}
