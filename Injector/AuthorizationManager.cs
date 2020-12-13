using System.IO;

namespace Injector
{
    class AuthorizationManager
    {
        public bool IsAuthorized { get; private set; }

        public void Authorize(string password)
        {
            if (File.Exists("password"))
            {
                var pass = File.ReadAllText("password");
                if (pass == password) IsAuthorized = true;
                else IsAuthorized = false;
            }
            else
            {
                File.WriteAllText("password", password);
                IsAuthorized = true;
            }
        }
    }
}