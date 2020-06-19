using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class ReportDatabase
    {
        private LinkedList<Report> reports;
        public ReportDatabase()
        {
            reports = new LinkedList<Report>();
        }
        public void addReport(int id, String owner, String date, long income, long outcome)
        {
            ReportData data = new ReportData(date, income, outcome);
            Report report = new Report(id, owner, data);
            reports.AddLast(report);
        }
        public void removeReport(int id)
        {
            for (int i = 0; i < reports.Count(); i++)
            {
                Report removeReport = reports.ElementAt<Report>(i);
                if (removeReport.getID() == id)
                {
                    reports.Remove(removeReport);
                }
            }
        }
        public Report getReport(String date)
        {
            for (int i = 0; i < reports.Count(); i++)
            {
                Report checkingReport = reports.ElementAt<Report>(i);
                if (checkingReport.getData().dateCreate == date) return checkingReport;
            }
            return null;
        }
    }
}
