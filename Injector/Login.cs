namespace Injector
{
    class Login
    {
        public PasswordRepository PasswordRepository { get; private set; }
        public Registration Registration { get; private set; }

        public void Show()
        {

        }

        public Login(PasswordRepository passwordRepository)
        {
            PasswordRepository = passwordRepository;
        }

        public bool LoginByPassword()
        {
            return false;
        }

        public void Registrate()
        {

        }
    }
}