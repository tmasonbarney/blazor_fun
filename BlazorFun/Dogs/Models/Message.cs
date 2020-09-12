using Dogs.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dogs.Models
{
    public class Message
    {
        [JsonConverter(typeof(ListStringJsonConverter))]
        public List<string> Dogs { get; set; }
    }
}
