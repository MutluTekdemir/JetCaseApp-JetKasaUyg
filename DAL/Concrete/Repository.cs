using DAL.Context;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
   public  class Repository<T> where T : BaseEntity
    {
        JetCaseContext db;


        public Repository() //constractur
        {
           db= new JetCaseContext();

        }  //Repository new lendiği yerde devreye giren ilk fonksiynumuz budur.
           //Ctor çağırılır. Bu metot db bağlantısını new'ler. 

       
        public void AddDal(T obje)
        {
            db.Set<T>().Add(obje);
            db.SaveChanges();
            //Libary enttiy framework

        }


        public void DeleteDal(T obje)
        {
            db.Set<T>().Remove(obje);
            db.SaveChanges();
        }
        public List<T> ListDal()
        {
            return db.Set<T>().ToList();
        }

        public T GetbyIdDal(int id)
        {

            return db.Set<T>().FirstOrDefault(x => x.Id ==id);
        }

        public void UpdateDal(int id, T obje)
        {
            //emlpoyee 
        //public string UserName { get; set; }          Hasan
        //public string Password { get; set; }   121
        //public string FirstName { get; set; }   Hasan
        //public string LastName { get; set; } yarak
        //public string TC { get; set; } 1231
        //public bool IsManager { get; set; }   hayır
        var objeyibul = GetbyIdDal(id);
            objeyibul = obje;
            db.SaveChanges();

        }
    }
}
