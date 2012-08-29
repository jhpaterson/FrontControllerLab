using System.Collections.Specialized;

namespace FrontControllerLab.Controller.Request
{
    public class WebRequest
    {
        public string RequestedUrl { get; set; }
        public NameValueCollection QueryArguments { get; set; }
    }
}