using Data.Infrastructure;
using Data.Repositories;
using Data.Repositories.Factory;
using Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ServiceFactory
    {
		public IRoleService GetRoleService(SecurityHelper securityHelper)
		{
			IConfiguration config = ConfigurationHelper.GetConfiguration();
			DbFactory _dbFactory = new DbFactory(config, securityHelper);
			RepositoryFactory repositoryFactory = new RepositoryFactory();
			IUnitOfWork unitOfWork = new UnitOfWork(_dbFactory);
			IRoleRepository roleRepository = repositoryFactory.CreateRoleRepository(_dbFactory, securityHelper);
			IRoleRightRepository roleRightRepository = repositoryFactory.CreateRoleRightRepository(_dbFactory, securityHelper);
			IRoleService roleService = new RoleService(roleRepository,roleRightRepository,unitOfWork);
			return roleService;
		}
		
	}
}
