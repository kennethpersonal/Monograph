using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Shared.Models
{
    public class MonographModel
    {
        [JsonPropertyName("monographId")]
        public Guid MonographId { get; set; }

        [JsonPropertyName("monographName")]
        public string MonographName { get; set; }

        [JsonPropertyName("monographType")]
        public string MonographType { get; set; }

        [JsonPropertyName("monographContents")]
        public List<MonographContent> MonographContents { get; set; }
    }

    public class MonographContent
    {
        [JsonPropertyName("header")]
        public string Header { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
