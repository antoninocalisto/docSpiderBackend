using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace docSpider.Models
{
    public class Pdf
    {
        public int id { get; set; }

        public string description { get; set; }

        public string name_file { get; set; }

        public int p_file { get; set; }

        public DateTime created_at { get; set; }
    }
}
