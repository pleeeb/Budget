using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    internal class MonthlyReport : IReport
    {
        public int id = 0;
        public void GetReportData()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "MonthlyReport";
        }
    }
}
