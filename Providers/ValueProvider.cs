using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft.Day1.Session1.Providers
{
    public class ValueProvider
    {
        public String GetValue()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
