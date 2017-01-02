using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PMRestApi.Models;
using PMRestApi.DAL.Contracts;

namespace PMRestApi.BLL
{
    public class ReleasesService
    {
        IReleaseRepository repository = null;

        internal ReleasesService(IReleaseRepository repository)
        {
            this.repository = repository;
        }
    }
}