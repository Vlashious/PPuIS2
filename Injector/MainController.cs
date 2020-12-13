using Service;

namespace Injector
{
    class MainController
    {
        public ICommand Command { get; private set; }
        public Login LoginController { get; private set; }

        public void SelectCommand()
        {

        }

        public void RunCommand(int command)
        {

        }

        public bool Login()
        {
            return false;
        }
    }
}