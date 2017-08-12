﻿using MyMVC.CodeLayers.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVC.CodeLayers.RepositoryLayer
{
    public interface IInventoryRepository : IMainRepository, IDisposable
    {
        string MyInventory(int id);
    }
}
