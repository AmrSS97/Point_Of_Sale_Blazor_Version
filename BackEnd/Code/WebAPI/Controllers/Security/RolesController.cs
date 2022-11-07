using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Helpers;
using Loggers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;

namespace WebAPI.Controllers
{
    [Route("api/Roles")]
    public class RolesController : BaseController
    {
        private readonly Services.IRoleService _roleService;
        private SecurityHelper _securityHelper;

        public RolesController(Services.IRoleService RoleService, SecurityHelper securityHelper)
        {
            _roleService = RoleService;
            _securityHelper = securityHelper;

        }
        [HttpGet]
        // GET api/Roles
        public List<Role> GetRoles()
        {
            return _roleService.GetAll();
        }

        // GET api/Roles/1/10
        //[HttpGet]
        [HttpGet("{PageNumber}/{PageSize}/{SortBy}/{SortDirection}")]
        public PagedResult<Role> GetRoles(int PageNumber, int PageSize, string SortBy = "", string SortDirection = "")
        {
            return _roleService.GetAll(PageNumber, PageSize, SortBy, SortDirection);
        }

        // GET api/Roles/5
        [HttpGet("{id}")]
        public IActionResult GetRole(Guid id)
        {
            ResultDTO result = new ResultDTO();
            Role role = _roleService.GetRole(id);
            if (role == null)
            {
                return NotFound();
            }
            result.Results = role;
            return Ok(result);
        }

        // PUT api/Roles/5
        [HttpPut("{id}")]
        public IActionResult PutRole(Guid id, [FromBody] Role role)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != role.RoleID)
            {
                return BadRequest();
            }

            try
            {
                _roleService.UpdateRole(role);
                _roleService.SaveRole();
            }
            catch (Exception ex)
            {
                Task.Run(() => {
                    ILogger logger = LoggerFactory.CreateLogger();
                    logger.Error(ex);
                });
                if (!RoleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode((int)HttpStatusCode.NoContent);
        }

        // POST api/Roles
        [HttpPost]
        public IActionResult PostRole([FromBody] Role role)
        {
            ResultDTO result = new ResultDTO();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _roleService.CreateRole(role);
            _roleService.SaveRole();
            result.Results = role;
            return Ok(result);
        }

        // DELETE api/Roles/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRole(Guid id)
        {
            ResultDTO result = new ResultDTO();
            Role role = _roleService.GetRole(id);
            if (role == null)
            {
                return NotFound();
            }
            _roleService.DeleteRole(role);
            _roleService.SaveRole();
            result.Results = role;
            return Ok(result);
        }


        private bool RoleExists(Guid id)
        {
            Role role = _roleService.GetRole(id);
            return role != null;
        }


        [HttpGet("getFeaturesRights")]
        public object getFeaturesRights()
        {

            return _roleService.getFeaturesRights();
        }


        [HttpGet("getRoleSideMenu")]
        public object getRoleSideMenu()
        {
            Guid role_id = _securityHelper.getRoleIDFromToken();
            return _roleService.getRoleSideMenu(role_id);
        }

        [HttpGet("CanAccess/{right_id}")]
        public bool canAccess(Guid right_id)
        {
            Guid role_id = _securityHelper.getRoleIDFromToken();
            return _roleService.canAccess(role_id, right_id);
        }

        // POST api/Roles/FilteredList"
        [HttpPost("FilteredList")]
        public Models.DTO.PagedResult<Role> LoadFilteredUsers(FilterModel<Role> FilterObject)
        {
            //if no search is applied
            if (FilterObject.SearchObject == null)
            {
                FilterObject.SearchObject = new Models.Role();
            }
            return _roleService.GetAll(FilterObject);
        }
        /// <summary>
        /// Add range of roles
        /// </summary>
        /// <param name="roles">Role list</param>
        /// <returns>Role list</returns>
        [HttpPost("AddRange")]
        public IActionResult AddRoleRange([FromBody] List<Role> roles)
        {
            _roleService.BulkInsert(roles);
            return Ok(roles);
        }
    }
}