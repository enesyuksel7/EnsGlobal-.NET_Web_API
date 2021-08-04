using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsGlobal.DAL
{
    public class ConnectionsDAL
    {
        public EnsGlobalDBEntities db = new EnsGlobalDBEntities();

        public void cpce()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }
    }
}
