using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Helpers;
using Loggers;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Models.Enums;
using Services;
using WebAPI.ActionFilters;

namespace WebAPI.Controllers
{
    [Route("api/Users")]
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;
        private readonly INotificationService _notificationService;
        private SecurityHelper _securityHelper;

        public UsersController(IUserService UserService, INotificationService notificationService, SecurityHelper securityHelper)
        {
            _userService = UserService;
            _notificationService = notificationService;
            _securityHelper = securityHelper;
        }

        [HttpGet]
        [SecurityFilter(RightEnum.ManageUsers, RightEnum.ManageRoles)]
        //[SecurityFilter((int)RightEnum.FailedEnum)]
        // GET api/Users
        public List<User> GetUsers()
        {
            return _userService.GetAll();
        }

        // GET api/Users/1/10
        [HttpGet("{PageNumber}/{PageSize}/{SortBy}/{SortDirection}")]
        public PagedResult<User> GetUsers(int PageNumber, int PageSize, string SortBy = "",string SortDirection = "")
        {
            return _userService.GetAll(PageNumber,PageSize,SortBy,SortDirection);
        }
        // GET api/Users/5
        [HttpGet("{id}")]
        public IActionResult GetUser(Guid id)
        {
            ResultDTO result = new ResultDTO();
            User user = _userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            result.Results = user;
            return Ok(result);
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public IActionResult PutUser(Guid id, [FromBody]User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.UserID)
            {
                return BadRequest();
            }

            try
            {
                User _user = _userService.GetUser(id);
                if (user.UserPassword != _user.UserPassword)
                {
                    user.UserPassword = _securityHelper.Md5Encryption(user.UserPassword);
                }
                user.Role = null;
                _userService.UpdateUser(user);
                _userService.SaveUser();
            }
            catch (Exception ex)
            {
                Task.Run(() => {
                    ILogger logger = LoggerFactory.CreateLogger();
                    logger.Error(ex);
                });
                if (!UserExists(id))
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

        // POST api/Users
        [HttpPost]
        public IActionResult PostUser([FromBody]User user)
        {
            ResultDTO result = new ResultDTO();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            user.UserPassword = _securityHelper.Md5Encryption(user.UserPassword);
            _userService.CreateUser(user);
            _userService.SaveUser();
            result.Results = user;
            _notificationService.SendRegisterationNotification(user.UserID);
            return Ok(result);
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            ResultDTO result = new ResultDTO();
            User user = _userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }

            _userService.DeleteUser(user);
            _userService.SaveUser();
            result.Results = user;
            return Ok(result);
        }

        private bool UserExists(Guid id)
        {
            User user = _userService.GetUser(id);
            return user != null;
        }

        // GET api/Users/5
        [HttpGet("CurrentUser")]
        public IActionResult GetCurrentUser()
        {
            ResultDTO result = new ResultDTO();
            Guid id = _securityHelper.getUserIDFromToken();
            User user = _userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            result.Results = user;
            return Ok(result);
        }

        // POST api/Users/FilteredList"
        [HttpPost("FilteredList")]
        public PagedResult<User> LoadFilteredUsers([FromBody]FilterModel<User> FilterObject)
        {
            //if no search is applied
            if (FilterObject.SearchObject == null)
            {
                FilterObject.SearchObject = new User();
            }
            return _userService.GetAll(FilterObject);
        }

        [HttpPost("TestEmail")]
        public IActionResult TestEmail()
        {
            _notificationService.SendCertificateNotification();
            return Ok();
        }

    }
}