﻿using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace ToplivoCodeFirst.Models
{
    public class FuelRepository : IRepository<Fuel>
    {
        private ToplivoContext db;
        public FuelRepository(ToplivoContext context)
        {
            db = context;

        }
        public void Create(Fuel fuel)
        {
            db.Fuels.Add(fuel);
        }

        public void Delete(int id)
        {
            Fuel fuel = db.Fuels.Find(id);
            if (fuel!=null)
            {
                db.Fuels.Remove(fuel);
            }
        }

        
        public IEnumerable<Fuel> Find(Func<Fuel, bool> predicate)
        {
            return db.Fuels.Where(predicate).ToList();
        }

        public Fuel Get(int id)
        {
            return db.Fuels.Find(id);
        }

        public IEnumerable<Fuel> GetAll()
        {
            return db.Fuels;
        }

        public IEnumerable<Fuel> GetNumberItems(int numberItems)
        {
            return db.Fuels.Take(numberItems);
        }

        

        public void Update(Fuel fuel)
        {
            db.Entry(fuel).State=EntityState.Modified;
        }
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}