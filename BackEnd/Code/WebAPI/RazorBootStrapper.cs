using Microsoft.AspNetCore.Hosting;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using System.IO;

namespace WebAPI
{
    public static class RazorBootStrapper
    {
        static IRazorEngineService razorService;
        public static void Init(IWebHostEnvironment WebHostEnvironment)
        {
            var config = new TemplateServiceConfiguration();
            config.TemplateManager = new DelegateTemplateManager();
            config.CachingProvider = new DefaultCachingProvider();
            razorService = RazorEngineService.Create(config);
            Engine.Razor = razorService;
            string currentDirec = WebHostEnvironment.ContentRootPath;

            // string UserRegisterPath = Path.Combine(currentDirec,"EmailTemplates", "UserRegister.cshtml");
            // string UserRegisterTemplate = File.ReadAllText(UserRegisterPath);
            // Engine.Razor.AddTemplate("UserRegister", UserRegisterTemplate);
            // Engine.Razor.Compile("UserRegister", typeof(Models.User));

            string UserRegisterPath = Path.Combine(currentDirec, "EmailTemplates", "certificate.html");
            string UserRegisterTemplate = File.ReadAllText(UserRegisterPath);
            Engine.Razor.AddTemplate("certificate", UserRegisterTemplate);
            Engine.Razor.Compile("certificate", typeof(Models.User));
        }
    }
}