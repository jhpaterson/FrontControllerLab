using System.Web;

namespace FrontControllerLab.Controller.Request
{
    public class WebRequestFactory
    {
        public WebRequest CreateFrom(HttpContext context)
        {
            var webrequest = new WebRequest();
            webrequest.RequestedUrl = context.Request.Url.ToString();
            webrequest.QueryArguments = context.Request.QueryString;

            return webrequest;
        }
    }
}