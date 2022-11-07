using Data.Infrastructure;
using Models;

namespace Data.Repositories
{

    public class RightRepository : BaseRepository<Right>, IRightRepository
    {
        public RightRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
            : base(dbFactory, securityHelper) { }

    }


}
