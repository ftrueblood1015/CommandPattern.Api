using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Domain.Models.Entities.Mtg
{
    public class CMCBarChartData
    {
        public string Name { get; set; }

        public List<double> Data { get; set; }

        public List<string> XAxisLabels { get; set; }

        public CMCBarChartData(string name)
        {
            Name = name;
            Data = new List<double>();
            XAxisLabels = new List<string>();
        }
    }
}
