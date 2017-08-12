using MyMVC.CodeLayers.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVC.CodeLayers.ServiceLayer
{
    public interface IInventoryService : IDisposable
    {
        void Add(Inventory i);
        void Update(Inventory i);
        void Delete(int id);
        List<Inventory> RetrieveAll();
    }
}
