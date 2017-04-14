using System;
using System.Collections.Generic;
using XPShare.Domain.Tags;

namespace XPShare.Domain.Experiences 
{
    public class Experience : IEntity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ProjectId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public IEnumerable<Guid> TagIds { get; set; }

        public string Description { get; set; }
    }
}
