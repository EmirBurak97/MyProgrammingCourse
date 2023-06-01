﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList(); //veritabanından sorgular isme göre arama yapar ve listeler.
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList(); //veritabanında unitprice price parametresinden büyük mü sorgular.
            }
        }

        public List<Product> GetByUnitPrice(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <=max).ToList(); //veritabanında unitprice min parametresi ve max parfametresinin arasında mı sorgular.
            }
        }

        public Product GetId(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.FirstOrDefault(p=>p.Id==id); //veritabanından sadece id'ye göre listeler.
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext()) 
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
