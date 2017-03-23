namespace Nancy.Demo.Authentication.Basic
{
    using System.Collections.Generic;
    using Nancy.Authentication.Basic;
    using Nancy.Security;

    public class UserValidator : IUserValidator
    {
        public IUserIdentity Validate(string username, string password)
        {
            if (username == "demo" && password == "demo")
            {
                return new user { UserName = username, Claims = new List<string> {"admin" } };
            }

            // Not recognised => anonymous.
            return null;
        }

        
    }
}
