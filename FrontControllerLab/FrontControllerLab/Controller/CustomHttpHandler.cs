using System.Web;
using FrontControllerLab.Controller.Request;

namespace FrontControllerLab.Controller
{
    public class CustomHttpHandler : IHttpHandler
    {

        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            var controller = new FrontController();
            var webRequestFactory = new WebRequestFactory();
            controller.Handle(webRequestFactory.CreateFrom(context));
        }
    }
}