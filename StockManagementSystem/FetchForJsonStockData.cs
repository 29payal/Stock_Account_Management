using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StockManagementSystem
{
    public class FetchForJsonStockData
    {
        public Stocks Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Stocks>(json);
                }
                catch(Exception)
                {
                    return null;
                }
            }
        }
    }
}
