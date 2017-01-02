using PMRestApi.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMRestApi.Models;

namespace PMRestApi.DAL
{
    internal class ReleaseRepository : IReleaseRepository
    {
        public IEnumerable<ReleaseBindingModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReleaseBindingModel GetByKey(string key)
        {
            throw new NotImplementedException();
        }
    }
}