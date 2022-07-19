using AutoMapper;
using IAMCandidateTest.Data;

namespace IAMCandidateTest.Repositories
{
    public class BaseRepository
    {
        internal readonly IAMCandidateTestDbContext context;
        public readonly IMapper mapper;

        public BaseRepository(IAMCandidateTestDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
    }
}

