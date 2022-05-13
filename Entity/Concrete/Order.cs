using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Order: BaseEntity,IEntity
    {
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int ProductId{ get; set; } //ekledik yeni 

        public int Unitprice { get; set; }// burdan devam et  (db güncelle ekle )
        
        public string ProductName { get; set; }
       
        

    }
}
