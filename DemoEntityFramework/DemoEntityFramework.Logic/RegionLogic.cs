using DemoEntityFramework.Data;
using DemoEntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFramework.Logic
{
    public class RegionLogic : BaseLogic, ILogic<Region>
    {

        public RegionLogic()
        {

        }

        public void Add(Region region)
        {
            _context.Region.Add(region);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var regionAEliminar = _context.Region.Find(id);
            _context.Region.Remove(regionAEliminar);
            _context.SaveChanges();
        }

        public List<Region> GetAll()
        {
            return _context.Region.ToList();
        }

        public void Update(Region region)
        {
            var regionUpdate = _context.Region.Find(region.RegionID);
            regionUpdate.RegionDescription = region.RegionDescription;
            _context.SaveChanges();
        }
    }
}
