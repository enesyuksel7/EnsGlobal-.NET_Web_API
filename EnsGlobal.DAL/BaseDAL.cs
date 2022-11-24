using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsGlobal.DAL
{
    public class BaseDAL
    {
        protected OtoGaleriDBEntities db = new OtoGaleriDBEntities();

        public BaseDAL()
        {
            db = new OtoGaleriDBEntities();
        }
    }
}
