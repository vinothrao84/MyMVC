using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyMVC.Models;
using MyMVC.CodeLayers.ServiceLayer;
using System.Collections;
using MyMVC.Areas.User.Models;

namespace MyMVC.CodeLayers.RepositoryLayer
{
    public class UserDL : IUserRepository, IMainRepository
    {
        private DataMgmtEntities _db;
        private bool disposed = false;

        public UserDL(DataMgmtEntities db)
        {
            this._db = db;
        }

        public void Add(UserModel u)
        {
            throw new NotImplementedException();
        }

        public void Update(UserModel u)
        {
            throw new NotImplementedException();
        }

        public List<UserContext> GetAll()
        {
            return _db.UserContexts.ToList();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}