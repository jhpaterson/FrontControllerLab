using FrontControllerLab.Controller.Request;
using FrontControllerLab.Controller.Navigation;

namespace FrontControllerLab.Controller.ActionCommands
{
    public class HomePageCommand : IActionCommand
    {
        private PageNavigator _pageNavigator = new PageNavigator();

        public void Process(WebRequest webRequest)
        {
            _pageNavigator.NavigateTo(PageDirectory.Home);
        }

        public bool CanHandle(WebRequest webRequest)
        {
            return webRequest.RequestedUrl.ToLower().Contains("home");
        }
    }
}