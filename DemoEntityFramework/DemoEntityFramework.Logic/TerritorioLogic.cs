using DemoEntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFramework.Logic
{
    public class TerritorioLogic : BaseLogic, ILogic<Territories>
    {
        public void Add(Territories territory)
        {
            _context.Territories.Add(territory);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            //var eliminarTerritory = _context.Territories.FirstOrDefault(x => x.TerritoryID == id);
        }

        public List<Territories> GetAll()
        {
            return _context.Territories.ToList();
        }

        public Territories GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Territories t)
        {
            throw new NotImplementedException();
        }
    }
}
