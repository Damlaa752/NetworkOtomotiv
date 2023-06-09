using NetworkOtomotiv.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.Business.Abstract
{
    public interface IRepository<Tentity>
        where Tentity : class
    {
        void Add(Tentity entity);
        void Update(Tentity entity);
        void Delete(Tentity entity);
        List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null);
        Tentity Get(int id);

    }

 }

