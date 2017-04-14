using System;
using System.Collections.Generic;
using XPShare.Domain.Users;

namespace XPShare.Domain.Stubs.Users
{
    public class UserRepository : StubRepository<User>, IUserRepository
    {
        protected override IEnumerable<User> InitialItems => new[]
            {
                new User {Name = "Sam", Id = Guid.Parse("d1076235-aa01-4d1e-b132-dc5671c6d0ef")},
                new User {Name = "John", Id = Guid.Parse("6cb1ca47-7a82-4858-af10-20354c5754b6")},
                new User {Name = "Mary", Id = Guid.Parse("75665762-4b42-4601-a9bd-8cb4086fd5c1")}
            };             
    }
}
