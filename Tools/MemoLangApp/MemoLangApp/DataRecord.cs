using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoLangApp
{
    internal class DataRecord
    {
        public string Date { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public string Grammar { get; set; } = "";
        public string Connection { get; set; } = "";
        public string Meaning { get; set; } = "";
        public string Sample { get; set; } = "";
        public string Others { get; set; } = "";

    }
}
