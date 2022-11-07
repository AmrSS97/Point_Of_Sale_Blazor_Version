using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Models.Enums.Extensions
{
    class EnumGuid : Attribute
    {
        public Guid Guid;

        public EnumGuid(string guid)
        {
            Guid = new Guid(guid);
        }
    }
}
