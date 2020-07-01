using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDll
{
    public interface IPhoneDictionary
    {
        List<Telephone> selectAll();
    }
}
