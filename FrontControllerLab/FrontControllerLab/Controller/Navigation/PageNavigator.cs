using System.Web;

namespace FrontControllerLab.Controller.Navigation
{
    public enum PageDirectory
    {
        Home,
        Users,
        Package
    }

    public class PageNavigator
    {
        public void NavigateTo(PageDirectory page)
        {
            switch (page)
            {
                case PageDirectory.Home:
                    HttpContext.Current.Server.Transfer("~/Views/Home/Home.aspx");
                    break;
                case PageDirectory.Users:
                    HttpContext.Current.Server.Transfer("~/Views/Users/UserList.aspx");
                    break;
            }
        }
    }
}