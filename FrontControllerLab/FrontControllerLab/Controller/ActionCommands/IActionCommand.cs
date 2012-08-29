using FrontControllerLab.Controller.Request;

namespace FrontControllerLab.Controller.ActionCommands
{
    public interface IActionCommand
    {
        void Process(WebRequest webRequest);
        bool CanHandle(WebRequest webRequest);
    }
}
