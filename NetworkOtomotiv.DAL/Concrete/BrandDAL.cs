using NetworkOtomotiv.Business.Concrete;
using NetworkOtomotiv.DAL.Abstract;
using NetworkOtomotiv.DAL.Context;
using NetworkOtomotiv.Entity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.DAL.Concrete
{
    public class BrandDAL : Repository<NetOtoDbContext,Brand>, IBrandDAL
    {
    }
}
