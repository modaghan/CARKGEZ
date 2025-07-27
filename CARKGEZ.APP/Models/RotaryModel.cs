using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARKGEZ.APP.Models
{
    public class RotaryModel
    {
        public List<RotarySector> Sectors { get; set; }

    }
    public class RotarySector
    {
        public string Venue { get; set; }
        public string Color { get; set; }
    }
}
