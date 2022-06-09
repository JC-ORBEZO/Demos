using DemoEntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFramework.Logic
{
    public class ShipperLogic : BaseLogic, ILogic<Shippers>
    {
        public void Add(Shippers shipper)
        {
            _context.Shippers.Add(shipper);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shipperAEliminar = _context.Shippers.Find(id);
            _context.Shippers.Remove(shipperAEliminar);
            _context.SaveChanges();
        }

        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }

        public void Update(Shippers shipper)
        {
            var shipperUpdate = _context.Shippers.Find(shipper.ShipperID);
            shipperUpdate.CompanyName = shipper.CompanyName;
            _context.SaveChanges();
        }
    }
}
