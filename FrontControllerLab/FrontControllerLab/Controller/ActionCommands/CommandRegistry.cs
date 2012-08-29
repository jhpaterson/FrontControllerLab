using System.Collections.Generic;
using System.Linq;
using FrontControllerLab.Controller.Request;

namespace FrontControllerLab.Controller.ActionCommands
{
    public class CommandRegistry
    {
        private IList<IActionCommand> _commands = new List<IActionCommand>();

        public CommandRegistry()
        {
            _commands.Add(new HomePageCommand());
            _commands.Add(new GetUsersCommand());
        }

        public IActionCommand GetCommandFor(WebRequest webrequest)
        {
            return _commands.FirstOrDefault(c => c.CanHandle(webrequest));
        }
    }
}