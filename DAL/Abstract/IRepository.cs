using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IRepository<T> where T : BaseEntity //Generic Repository kullandım.Uygulama Boyunca ortak kullanacağım metotları tek bir yerde tanımlaayrak her seferinde yeniden oluşturmak istemedim. Değişen tek parametre ise bu işlemi hangi model için yaptıkları.Product,Category veya supplier gibi. Yani, ortak işlemlerimiz için genel bir yapı kurup, her bir modelin bu genel yapı üzerinden o işlemi gerçekleştirmesini sağladım.
    {
        void AddDal(T obje);
        void UpdateDal(int id, T obje);
        void DeleteDal(T obje);
        List<T> ListDal();
        T GetbyIdDal(int id);
    }
}
