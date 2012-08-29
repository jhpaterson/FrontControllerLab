using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrontControllerLab.Model
{
    public class PackageRepository
    {
        private gcutourswmEntities context = new gcutourswmEntities();

        public IQueryable<Package> GetAll()
        {
            return context.Packages;
        }

        public Package GetByPackageId(int target)
        {
            return context.Packages.SingleOrDefault(p => p.packageID == target);
        }
    }
}