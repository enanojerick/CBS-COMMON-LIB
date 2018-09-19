using System;
using System.Collections.Generic;
using System.Text;

namespace CBS.Common.Services.Email
{
    public class EmailSettings
    {
        public EmailSettings(string host,
                             string username,
                             string password,
                             int port)
        {
            if (string.IsNullOrEmpty(host))
                throw new ArgumentNullException("host");

            if (string.IsNullOrEmpty(username))
                throw new ArgumentNullException("username");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            this.Host = host;
            this.UserName = username;
            this.Password = password;
            this.Port = port;
        }

        public string Host { get; }
        public string UserName { get; }
        public string Password { get; }
        public int Port { get; }
    }
}
