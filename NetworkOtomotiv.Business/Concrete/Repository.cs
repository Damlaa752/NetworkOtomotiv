﻿using Microsoft.EntityFrameworkCore;
using NetworkOtomotiv.Business.Abstract;
using NetworkOtomotiv.Entity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.Business.Concrete
{
    public class Repository<Tcontext, Tentity> : IRepository<Tentity>
        where Tentity : class,new()
        where Tcontext : DbContext, new()
    {
        public void Add(Tentity entity)
        {
            using (var db = new Tcontext())
            {
                db.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (var db = new Tcontext())
            {
                db.Remove(entity);
                db.SaveChanges();
            }
        }

        public Tentity Get(int id)
        {
            using (var db = new Tcontext())
            {
                var entity = db.Find<Tentity>(id);
                return entity;
            }
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (var db = new Tcontext())
            {
                return filter == null ? db.Set<Tentity>().ToList() : db.Set<Tentity>().Where(filter).ToList();
            }
        }
        public void Update(Tentity entity)
        {
            using (var db = new Tcontext())
            {
                db.Update(entity);
                db.SaveChanges();
            }
        }
    }
}
