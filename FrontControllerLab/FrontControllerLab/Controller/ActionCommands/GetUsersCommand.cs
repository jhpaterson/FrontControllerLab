using FrontControllerLab.Controller.Storage;
using FrontControllerLab.Controller.Request;
using FrontControllerLab.Controller.Navigation;
using FrontControllerLab.Model;

namespace FrontControllerLab.Controller.ActionCommands
{
    public class GetUsersCommand : IActionCommand
    {
        private ViewStorage _storage = new ViewStorage();
        private PageNavigator _pageNavigator = new PageNavigator();
        private UserRepository _repository = new UserRepository();


        public void Process(WebRequest webRequest)
        {
            _storage.Add(ViewStorageKeys.Users, _repository.GetAll());
            _pageNavigator.NavigateTo(PageDirectory.Users);
        }

        public bool CanHandle(WebRequest webRequest)
        {
            return webRequest.RequestedUrl.ToLower().Contains("users");
        }
    }
}