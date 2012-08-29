using System;
using System.Collections.Generic;
using FrontControllerLab.Controller.Storage;
using FrontControllerLab.Model;

namespace FrontControllerLab.Views.Users
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var storage = new ViewStorage();
            var users = (IEnumerable<User>)storage.Get(ViewStorageKeys.Users);
            Gridview1.DataSource = users;
            Gridview1.DataBind();
        }
    }
}