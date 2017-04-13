using System;

namespace XPShare.Domain.Users
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string GravatarEmail { get; set; }
    }
}
