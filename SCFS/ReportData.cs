using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class ReportData
    {
        public String dateCreate;
        public long income;
        public long outcome;
        public long profit;
        public ReportData(String date, long income, long outcome)
        {
            this.dateCreate = date;
            this.income = income;
            this.outcome = outcome;
            this.profit = outcome - income;
        }
    }
}
