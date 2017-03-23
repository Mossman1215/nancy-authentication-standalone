using System;
using System.Collections.Generic;
using Nancy.Security;

namespace Nancy.Demo.Authentication.Basic
{
    public class user : IUserIdentity
    {
        public string UserName { get; set; }
        public IEnumerable<string> Claims { get; set; }
    }
}