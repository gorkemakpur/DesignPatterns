using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
    public class EfProcessRepository : GenericRepository<Process>
    {
        public EfProcessRepository(Context context) : base(context)
        {
        }
    }
}
