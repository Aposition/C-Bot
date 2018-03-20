using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Test
{
    class Utilities
    {
        private static Dictionary<string, string> alert;

        static Utilities()
        {
            string json = File.ReadAllText("NewFolder1/alert.json");
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            alert = data.ToObject<Dictionary<string, string>>();
        }

        public static string GetAlert(string key)
        {
            if (alert.ContainsKey(key)) return alert[key];
            return "";
        }
    }
}
