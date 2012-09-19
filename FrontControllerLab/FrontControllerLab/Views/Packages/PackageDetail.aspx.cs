using System;
using System.Collections.Generic;
using FrontControllerLab.Controller.Storage;
using FrontControllerLab.Model;

namespace FrontControllerLab.Views.Packages
{
    public partial class PackageDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var storage = new ViewStorage();
            var package = storage.Get(ViewStorageKeys.Packages) as Package;
            if (package != null)
            {
                LabelName.Text = package.packagename;
                LabelDescription.Text = package.description;
                LabelPrice.Text = package.adultprice.ToString();
            }
        }
    }
}