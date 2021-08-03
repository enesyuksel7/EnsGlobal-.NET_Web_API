using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace EnsGlobal.DAL
{
    public class SatislarDAL
    {
        EnsGlobalDBEntities db = new EnsGlobalDBEntities();

        public void cpce()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        public IQueryable GetAllSatislar()
        {
            cpce();
            var sorgu = (from x in db.Satislar select new { x.SatisID, x.UrunID, x.Yetkili, x.Tarih, x.Ucret, x.Vergi });
            return sorgu;
        }

        public IQueryable GetSatislarById(int id)
        {
            cpce();
            var sorgu = (from x in db.Satislar where x.SatisID == id select new {x.UrunID, x.Yetkili, x.Tarih, x.Ucret, x.Vergi });
            return sorgu;
        }

        public Satislar CreateSatis(Satislar satis)
        {
            cpce();
            db.Satislar.Add(satis);
            db.SaveChanges();
            return satis;
        }
        /// <summary>
        /// satislari guncelle
        /// </summary>
        /// <param name="id"></param>
        /// <param name="satis"></param>
        /// <returns></returns>
        public Satislar UpdateSatis(int id, Satislar satis)
        {
            cpce();
            db.Entry(satis).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return satis;
        }

        public void DeleteSatis(int id)
        {
            cpce();
            db.Satislar.Remove(db.Satislar.Find(id));
            db.SaveChanges();
        }

        public bool IsThereAnySatis(int id)
        {
            cpce();
            return db.Satislar.Any(x => x.SatisID == id);
        }

    }
}
