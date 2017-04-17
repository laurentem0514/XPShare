using System.Collections.Generic;

namespace XPShare.Domain.Tags
{
    public interface ITagRepository : IRepository<Tag>
    {
        IEnumerable<Tag> Search(string text);
    }
}
