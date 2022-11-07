using Data.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ItemRepository : BaseRepository<Item>,IItemRepository
    {
        public ItemRepository(IDbFactory dbFactory, Helpers.SecurityHelper securityHelper)
        : base(dbFactory, securityHelper) { }
    }
}
