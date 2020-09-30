using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Religion
    {
        public int id { get; set; }
        public string religion_name { get; set; }
        public string note { get; set; }
        public DateTime Date_created { get; set; }
        public string Created_by { get; set; }
        public string Updated_by { get; set; }
        public DateTime Date_updated { get; set; }
        public int active { get; set; }
    }
}
