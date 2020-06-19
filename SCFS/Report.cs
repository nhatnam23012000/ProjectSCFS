using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS
{
    public class Report
    {
        private int id;
        private String owner;
        private ReportData data;
        public Report(int id, String owner, ReportData data)
        {
            this.id = id;
            this.owner = owner;
            this.data = data;
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public void setOwner(String owner)
        {
            this.owner = owner;
        }
        public void setData(ReportData data)
        {
            this.data = data;
        }
        public int getID()
        {
            return id;
        }
        public String getOwner()
        {
            return owner;
        }
        public ReportData getData()
        {
            return data;
        }
    }
}
