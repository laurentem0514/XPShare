using System;

namespace XPShare.Domain.Users
{
    public class User : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string GravatarEmail { get; set; }
    }
}
