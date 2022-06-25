using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFramework.Logic
{
    public interface ILogic<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T t);
        void Delete(int id);
        void Update(T t);
    }
}
