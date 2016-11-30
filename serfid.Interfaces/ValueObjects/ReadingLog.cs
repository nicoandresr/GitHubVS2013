using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serfid.Interfaces.ValueObjects
{
    public class ReadingLog : ReadingInfo
    {
        public string Device { get; set; }
        public string ImageUrl { get; set; }
    }
}
