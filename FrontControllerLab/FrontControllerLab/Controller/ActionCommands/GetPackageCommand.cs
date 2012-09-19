using System;
using FrontControllerLab.Controller.Storage;
using FrontControllerLab.Controller.Request;
using FrontControllerLab.Controller.Navigation;
using FrontControllerLab.Model;

namespace FrontControllerLab.Controller.ActionCommands
{
    public class GetPackageCommand : IActionCommand
    {
        private ViewStorage _storage = new ViewStorage();
        private PageNavigator _pageNavigator = new PageNavigator();
        private PackageRepository _repository = new PackageRepository();

        public void Process(WebRequest webRequest)
        {
            var packageId = webRequest.QueryArguments["packageid"] != null ?
                Int32.Parse(webRequest.QueryArguments["packageid"]) : 0;
            var result = _repository.GetByPackageId((packageId));
            _storage.Add(ViewStorageKeys.Packages, result);
            _pageNavigator.NavigateTo(PageDirectory.Package);
        }

        public bool CanHandle(WebRequest webRequest)
        {
            return webRequest.RequestedUrl.ToLower().Contains("package");
        }
    }
}