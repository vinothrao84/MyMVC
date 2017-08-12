using MyMVC.Areas.User.Models;
using MyMVC.CodeLayers.ServiceLayer;
using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVC.CodeLayers.ServiceLayer
{
    public interface IUserService : IDisposable
    {
        void Add(UserModel u);
        void Update(UserModel i);
        void Delete(int id);
        List<UserContext> GetAll();
    }
}
