using Data.Infrastructure;
using Helpers;
using Microsoft.Extensions.Configuration;

namespace Data.Repositories.Factory
{
	public class RepositoryFactory
	{
		public RepositoryFactory()
		{
		}
		public IRoleRepository CreateRoleRepository(IDbFactory dbFactory, SecurityHelper _securityHelper)
		{
			IRoleRepository repo = new RoleRepository(dbFactory, _securityHelper);
			return repo;
		}
		public IRoleRightRepository CreateRoleRightRepository(IDbFactory dbFactory,SecurityHelper _securityHelper)
		{
			IRoleRightRepository repo = new RoleRightRepository(dbFactory, _securityHelper);
			return repo;
		}

	}
}
