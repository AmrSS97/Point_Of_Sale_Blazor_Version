using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;


namespace Helpers
{
    public class SecurityHelper
    {
        /// <summary>
        /// Claims Instance
        /// </summary>
        private readonly ClaimsPrincipal _principal;

        public SecurityHelper(IHttpContextAccessor httpContextAccessor)
        {
            _principal = httpContextAccessor?.HttpContext?.User;

        }
        /// <summary>
        /// Encrypt Using MD5
        /// </summary>
        /// <param name="src">String to be Encrypted</param>
        /// <returns></returns>
        public  String Md5Encryption(String src)
        {
            System.Text.UnicodeEncoding encode = new System.Text.UnicodeEncoding();
            System.Text.Decoder decode = encode.GetDecoder();
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] password = new byte[encode.GetByteCount(src)];
            char[] char_password = new char[encode.GetCharCount(password)];
            password = encode.GetBytes(src);
            password = md5.ComputeHash(password);
            int length = encode.GetByteCount(src);
            if (length > 16)
                length = 16;
            decode.GetChars(password, 0, length, char_password, 0);
            return new String(char_password);

        }

        public Guid getUserIDFromToken()
        {
            string APPID = "";
            Guid id = Guid.Empty;
            if (_principal != null)
            {
                // Get the claims values
                APPID = _principal.Claims.Where(c => c.Type == "UserId")
                    .Select(c => c.Value).SingleOrDefault();
            }
            Guid.TryParse(APPID,out id);
            return id;
        }

        public Guid getRoleIDFromToken()
        {
            string APPID = "";
            Guid id = Guid.Empty;
            // Get the claims values
            if (_principal != null)
            {
                APPID = _principal.Claims.Where(c => c.Type == "RoleId")
                    .Select(c => c.Value).SingleOrDefault();
            }
            Guid.TryParse(APPID, out id);
            return id;
        }

        public Guid? getCompanyIDFromToken()
        {
            string APPID = "";
            
            if (_principal != null)
            {
                // Get the claims values
                APPID = _principal.Claims.Where(c => c.Type == "CompanyId")
                    .Select(c => c.Value).SingleOrDefault();
                if (!string.IsNullOrEmpty(APPID))
                {
                    Guid id = Guid.Empty;
                    Guid.TryParse(APPID, out id);
                    return id;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

    }
}
