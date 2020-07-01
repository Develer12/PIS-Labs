using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace entity_VALIDATION
{
    public class CheckTypeAttribute : ValidationAttribute
    {
        private static string[] _types;
        public CheckTypeAttribute(string[] types)
        {
            _types = types;
        }
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string strval = value.ToString();
                for (int i = 0; i < _types.Length; i++)
                {
                    if (strval == _types[i])
                        return true;
                }
            }
            return false;
        }
    }
}
