using FrontControllerLab.Controller.Request;
using FrontControllerLab.Controller.Navigation;


namespace FrontControllerLab.Controller.ActionCommands
{
    public class MissingPageCommand : IActionCommand
    {
        private PageNavigator _pageNavigator = new PageNavigator();

        public void Process(WebRequest webRequest)
        {
            _pageNavigator.NavigateTo(PageDirectory.MissingPage);
        }

        public bool CanHandle(WebRequest webRequest)
        {
            return true;
        }
    }
}