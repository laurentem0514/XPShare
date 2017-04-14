using System;

namespace XPShare.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
