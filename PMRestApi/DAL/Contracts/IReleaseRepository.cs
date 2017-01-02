using PMRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMRestApi.DAL.Contracts
{
    internal interface IReleaseRepository
    {
        IEnumerable<ReleaseBindingModel> GetAll();
        ReleaseBindingModel GetByKey(string key);
        
    }
}