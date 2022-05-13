using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Category : BaseEntity,IEntity  //Ientity kalıtım almadım sebebi ise implement etmek istemedim.Bunun için basentity adında bir clas oluşturup onun içerisine Ientity adında kalıtım aldım .Ientitiynin zorunlu kıldığı Propu tanıımlarayark BaseEntity clasından Tüm  Entity claslarıma kalıtım aldım.
    {
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
      

    }
}
