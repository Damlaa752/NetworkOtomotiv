using NetworkOtomotiv.Business.Abstract;
using NetworkOtomotiv.Business.Concrete;
using NetworkOtomotiv.DAL.Concrete;
using NetworkOtomotiv.Entity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.DAL.Abstract
{
    public interface IBrandDAL: IRepository<Brand>
    {
    }
}
