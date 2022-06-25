using DemoEntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoEntityFramework.Web.Models
{
    public class ShipperListadoModel
    {
        public ShipperListadoModel()
        {
            ListShippers = new List<Shippers>();
        }

        public int Cantidad { get; set; }
        public List<Shippers> ListShippers { get; set; }
    }
}