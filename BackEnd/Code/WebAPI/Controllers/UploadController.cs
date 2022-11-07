using System;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Helpers;
using Loggers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Upload")]
    public class UploadController : Controller
    {

        private IWebHostEnvironment _hostingEnvironment;
        private readonly ManageResources _manageRes;
        public UploadController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _manageRes = new ManageResources();
        }

        [HttpPost, DisableRequestSizeLimit]
        public ActionResult UploadFile()
        {
            ResultDTO result = new ResultDTO();
            try
            {
                string fileName = string.Empty;
                var file = Request.Form.Files[0];
                string folderName = "Uploads";
                string webRootPath = _hostingEnvironment.WebRootPath;
                string newPath = Path.Combine(webRootPath, folderName);
                string returnPath = string.Empty;
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                if (file.Length > 0)
                {
                    fileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + "_" + ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    string fullPath = Path.Combine(newPath, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    returnPath = $"{Path.DirectorySeparatorChar}{folderName}{Path.DirectorySeparatorChar}{fileName}";
                }
                result.Results = returnPath;
                return Ok(result);
            }
            catch (Exception ex)
            {                  
                Task.Run(()=> {
                    ILogger logger = LoggerFactory.CreateLogger();
                    logger.Error(ex);
                });                
                result.Errors.Add(_manageRes.GetErrorByName("UploadFailed"));
                return Ok(result);
            }
        }
    }

}