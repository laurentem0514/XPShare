using System;
using System.Collections.Generic;
using XPShare.Domain.Projects;

namespace XPShare.Domain.Stubs.Projects
{
    public class ProjectRepository : StubRepository<Project>, IProjectRepository
    {
        protected override IEnumerable<Project> InitialItems => new List<Project>
        {
            new Project {Name = "Comcast", Id = Guid.Parse("caec1457-203a-46f6-b281-95299fae5340")},
            new Project {Name = "ChairShare", Id = Guid.Parse("11b94d42-1ab8-4b1d-a589-eae5e6a5f700")},
            new Project {Name = "Good News", Id = Guid.Parse("ab35e576-c7b5-4481-a986-631f9d1ee5f8")}
        };
    }
}
