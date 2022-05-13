using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product: BaseEntity //Birdaha Ientitye ortak bir prop eklediğimde tekrar tekrar uğraşmamak için İnterfacei kullanıyorum.
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public int CategoryId { get; set; }






        public virtual Category Category { get; set; }

        public virtual Supplier Supplier { get; set; }
     
    }
}
