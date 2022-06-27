using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    internal class YearlyReport : IReport
    {
        public int id = 1;
        public void GetReportData()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "YearlyReport";
        }
    }
}
