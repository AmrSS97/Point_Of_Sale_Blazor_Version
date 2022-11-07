

using Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Models;
using Models.DTO;
using Models.Enums;
using Models.Enums.Extensions;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.ActionFilters
{
    public class SecurityFilter : TypeFilterAttribute
    {
        public SecurityFilter(params RightEnum[] rights) : base(typeof(PermissionsFilter))
        {
             Arguments = new object[] { rights };
        }
        private class PermissionsFilter : IActionFilter
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly List<Guid> _rightIds;

            public PermissionsFilter(IHttpContextAccessor httpContextAccessor, RightEnum[] rightIds)
            {
                _httpContextAccessor = httpContextAccessor;
                _rightIds = new List<Guid>();
                for (int i = 0; i < rightIds.Length; i++)
                {
                    _rightIds.Add(rightIds[i].GetEnumGuid());
                }
            }
            public void OnActionExecuting(ActionExecutingContext context)
            {
                SecurityHelper _securityHelper = new SecurityHelper(_httpContextAccessor);
                Guid role_id = _securityHelper.getRoleIDFromToken();
                //int right_id = (int)context.ActionArguments["rightId"];
                // check form access for user 
                if (_rightIds!=null && _rightIds.Count == 0)
                {
                    return;
                }
                ServiceFactory _serviceFactory = new ServiceFactory();
                IRoleService _roleService = _serviceFactory.GetRoleService(_securityHelper);
                bool canAccess = _roleService.canAccess(role_id, _rightIds);
                if (!canAccess)
                {
                    ResultDTO result = new ResultDTO();
                    result.Errors.Add(new ErrorDTO() { ErrorMessageEN = StatusCodes.Status403Forbidden.ToString() + ": Access Denied" });
                    context.Result = new ObjectResult("")
                    {
                        Value = result,
                        StatusCode = StatusCodes.Status403Forbidden
                    };
                    return;
                }
            }

            public void OnActionExecuted(ActionExecutedContext context)
            {
            }

        }
    }
}
