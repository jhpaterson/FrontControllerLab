using FrontControllerLab.Controller.Request;
using FrontControllerLab.Controller.ActionCommands;

namespace FrontControllerLab.Controller
{
    public class FrontController
    {
        private CommandRegistry _commandRegistry = new CommandRegistry();

        public void Handle(WebRequest request)
        {
            IActionCommand command = _commandRegistry.GetCommandFor(request);
            command.Process(request);
        }
    }
}