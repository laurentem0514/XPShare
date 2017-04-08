using System;
using System.Collections.Generic;
using System.Text;

namespace XPShare.Domain.Users
{
    public interface IUserRepository
    {
        void Add(User user);

        User Get(Guid id);

        IEnumerable<User> GetAll();
    }

    public class StubUserRepository : IUserRepository
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public User Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
           
            return new List<User>
            {
                new User {Name = "Sam"},
                new User {Name = "John"},
                new User {Name = "Mary"}
            };
        }
    }


}
