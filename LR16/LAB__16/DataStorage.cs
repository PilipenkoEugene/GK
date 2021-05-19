using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Lab16
{
    class DataStorage : DataInterface
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;
            }
        }

        private List<RawDataItem> rawdata;
        private List<SummaryDataItem> sumdata;
        private char devider = '*';
        public DataStorage() { }

        private void BuildSummary()
        {
            Dictionary<int, float> tmp = new Dictionary<int, float>();
            double iterBus = 0;
            double pr = 0, hm = 0;
            int prc = 0, hmc = 0;
            double muchCost = -1, airCost = 0;

            foreach (var item in rawdata)
            {
                if (item.From == "Химия")
                {
                    iterBus += item.Cost - item.To;
                    hm += item.To;
                    hmc++;
                }
                else
                {
                    iterBus += item.Cost - item.To;
                    pr += item.To;
                    prc++;
                }
            }

            sumdata = new List<SummaryDataItem>();
            sumdata.Add(new SummaryDataItem()
            {
                GroupName = "Суммарная прибыль",
                GroupValue = iterBus
            });
            sumdata.Add(new SummaryDataItem()
            {
                GroupName = "Средняя закупочная продукты",
                GroupValue = pr/prc
            });
            sumdata.Add(new SummaryDataItem()
            {
                GroupName = "Средняя закупочная химия",
                GroupValue = hm/hmc
            });
        }
        private bool InitData(String datapath)
        {
            rawdata = new List<RawDataItem>();

            try
            {
                StreamReader sr = new StreamReader(datapath);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        Type = items[0].Trim(),
                        From = items[1].Trim(),
                        To = Convert.ToDouble(items[2].Trim(), CultureInfo.InvariantCulture),
                        Cost = Convert.ToDouble(items[3].Trim(), CultureInfo.InvariantCulture),
                    };
                    rawdata.Add(item);
                }
                sr.Close();
                BuildSummary();
            } catch (IOException ex)
            {
                return false;
            }
            return true;
        }

        public static DataStorage DataCreator(String path)
        {
            DataStorage d = new DataStorage();
            if (d.InitData(path))
                return d;
            else
                return null;
        }

        public List<RawDataItem> GetRawData()
        {
            if (this.IsReady)
                return rawdata;
            else
                return null;
        }

        public List<SummaryDataItem> GetSummaryData()
        {
            if (this.IsReady)
                return sumdata;
            else
                return null;
        }
    }
}
