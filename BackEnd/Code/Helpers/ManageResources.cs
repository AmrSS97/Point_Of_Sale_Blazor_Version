using Models.DTO;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;

namespace Helpers
{
    public class ManageResources
    {

        /// <summary>
        /// Manage system messages resource
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public ErrorDTO GetErrorByName(string Name)
        {
            ErrorDTO error = new ErrorDTO();
            //init system messages resource
            ResourceManager manager = new ResourceManager("WebAPI.GlobalResources.SystemMessages", Assembly.Load("WebAPI"));
            error.ErrorMessageEN = manager.GetString(Name, new System.Globalization.CultureInfo("en-US"));
            error.ErrorMessageAR = manager.GetString(Name, new System.Globalization.CultureInfo("ar-SA"));
            return error;
        }
        
        /// <summary>
        /// Manage system messages resource
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public ErrorDTO GetErrorByName(string name, Dictionary<string, string> dictionary)
        {
            ErrorDTO error = GetErrorByName(name);
            foreach (var item in dictionary)
            {
                error.ErrorMessageEN = error.ErrorMessageEN?.Replace(item.Key, item.Value);
                error.ErrorMessageAR = error.ErrorMessageAR?.Replace(item.Key, item.Value);
            }
            return error;
        }
    }
}
