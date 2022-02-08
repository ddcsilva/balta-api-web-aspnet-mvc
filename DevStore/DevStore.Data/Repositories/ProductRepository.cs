﻿using DevStore.Data.Context;
using DevStore.Domain;
using DevStore.Domain.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DevStore.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private AppDataContext _db;

        public ProductRepository()
        {
            _db = new AppDataContext();
        }

        public void Create(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Products.Remove(Get(id));
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public List<Product> Get()
        {
            return _db.Products.ToList();
        }

        public Product Get(int id)
        {
            return _db.Products.Find(id);
        }

        public void Update(Product product)
        {
            _db.Entry<Product>(product).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
