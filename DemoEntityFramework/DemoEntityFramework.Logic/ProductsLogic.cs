using DemoEntityFramework.Data;
using DemoEntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFramework.Logic
{
    public class ProductsLogic : BaseLogic, ILogic<Products>
    {

        public ProductsLogic()
        {

        }

        public void Add(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var productoAEliminar = _context.Products.FirstOrDefault(x => x.ProductID == id);
            _context.Products.Remove(productoAEliminar);
            _context.SaveChanges();
        }

        public List<Products> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Update(Products product)
        {
            var productUpdate = _context.Products.Find(product.ProductID);
            productUpdate.ProductName = product.ProductName;
            _context.SaveChanges();
        }
    }
}
