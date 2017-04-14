using System;
using System.Collections.Generic;
using XPShare.Domain.Experiences;

namespace XPShare.Domain.Stubs.Experiences
{
    public class ExperienceRepository : StubRepository<Experience>, IExperienceRepository
    {
        protected override IEnumerable<Experience> InitialItems => new List<Experience>
        {
            new Experience {Description = "I used react", Id = Guid.Parse("0c8f8444-6d16-454c-be15-7e422c5e022e")},
            new Experience {Description = "I used Sitecore", Id = Guid.Parse("58d76ff9-8052-4ba0-9b63-23b8da5d4d05")},
            new Experience {Description = "I used apis", Id = Guid.Parse("499ce59f-f0ae-4fbc-a2ce-882a821b9f41")}
        };
    }
}
