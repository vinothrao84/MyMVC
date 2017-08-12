using MyMVC.Areas.User.Models;
using MyMVC.CodeLayers.RepositoryLayer;
using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVC.CodeLayers.ServiceLayer
{
    public class UserSL : IUserService
    {
        private IUserRepository _userRepo;

        public UserSL()
        {
            this._userRepo = new UserDL(new DataMgmtEntities());
        }

        public void Add(UserModel u)
        {
            throw new NotImplementedException();
        }

        public void Update(UserModel u)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserContext> GetAll()
        {
            return _userRepo.GetAll();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}