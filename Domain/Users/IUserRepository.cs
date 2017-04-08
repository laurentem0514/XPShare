using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XPShare.Domain.Users
{
    public interface IUserRepository
    {
        void Add(User user);

        User Get(Guid id);

        IEnumerable<User> GetAll();

        void Delete(Guid id);
    }

    public class StubUserRepository : IUserRepository
    {   
        private List<User> _users = new List<User>
            {
                new User {Name = "Sam", Id = Guid.Parse("d1076235-aa01-4d1e-b132-dc5671c6d0ef")},
                new User {Name = "John", Id = Guid.Parse("6cb1ca47-7a82-4858-af10-20354c5754b6")},
                new User {Name = "Mary", Id = Guid.Parse("75665762-4b42-4601-a9bd-8cb4086fd5c1")}
            };

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Delete(Guid id)
        {
            _users.RemoveAll(x => x.Id == id);
        }

        public User Get(Guid id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }
    }


}
