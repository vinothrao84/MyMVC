using MyMVC.CodeLayers.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.CodeLayers.ServiceLayer
{
    public class Inventory : IInventoryService
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double amount { get; set; }
        public int ownedby { get; set; }

        public void Add(Inventory i)
        {
            throw new NotImplementedException();
        }

        public void Update(Inventory i)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Inventory> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}