using System;

namespace XPShare.Domain.Projects
{
    public class Project : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
