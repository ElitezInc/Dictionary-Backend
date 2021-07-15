using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Translation
    {
        [IgnoreDataMember]
        public int ID { get; set; }
        public string English { get; set; }
        public string Hungarian { get; set; }
        public string Spanish { get; set; }
        public string Chinese { get; set; }
        public string Portuguese { get; set; }
    }
}