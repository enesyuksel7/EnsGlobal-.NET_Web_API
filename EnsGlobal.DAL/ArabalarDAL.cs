using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsGlobal.DAL
{
    public class ArabalarDAL
    {
        OtoGaleriDBEntities db = new OtoGaleriDBEntities(); //BaseDAL da tanımlıyoruz

        ///////////////// GET METOTLARI ///////////////////////////

        //IEnumerable ile

        //public IEnumerable<Arabalar> GetAllArabalar()
        //{
        //    db.Configuration.ProxyCreationEnabled = false;
        //    return db.Arabalar;
        //}

        //List ile

        public List<Arabalar> GetAllArabalar()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Arabalar.ToList();
        }

        public Arabalar GetArabalarById(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Arabalar.Find(id);
        }

        public Arabalar CreateAraba(Arabalar araba)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.Arabalar.Add(araba);
            db.SaveChanges();
            return araba;
        }

        public Arabalar UpdateAraba(int id, Arabalar araba)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.Entry(araba).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return araba;
        }

        public void DeleteAraba(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            db.Arabalar.Remove(db.Arabalar.Find(id));
            db.SaveChanges();
        }

        public bool IsThereAnyAraba(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.Arabalar.Any(x => x.ArabaID == id);
        }
    }
}
