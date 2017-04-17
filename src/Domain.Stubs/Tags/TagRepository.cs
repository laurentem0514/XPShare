using System;
using System.Collections.Generic;
using System.Linq;
using XPShare.Domain.Tags;

namespace XPShare.Domain.Stubs.Tags
{ 
    public class TagRepository : StubRepository<Tag>, ITagRepository
    {
        protected override IEnumerable<Tag> InitialItems => new List<Tag>
        {
            new Tag {Name = "VisualStudio", Id = Guid.Parse("e982b399-bea0-4c8e-b5cf-92d96e359d64")},
            new Tag {Name = "react.js", Id = Guid.Parse("4a9d92b6-d142-4bcb-a38a-2a77121d7fe9")},
            new Tag {Name = ".NET Core", Id = Guid.Parse("c34d7a76-1237-4440-890f-25a93c9aca20")}
        };

        public IEnumerable<Tag> Search(string text)
        {
            if (text == null)
            {
                return Enumerable.Empty<Tag>();
            }
            return _items.Where(i => i.Name.StartsWith(text));
        }
    }
}