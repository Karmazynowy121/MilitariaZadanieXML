using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace militaria_zadanie
{
    public class Area
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nazwa")]
        public string Name { get; set; }
        [JsonPropertyName("id-nadrzedny-element")]
        public int ParentId { get; set; }
        [JsonPropertyName("nazwa-poziom")]
        public string LevelName { get; set; }
        [JsonPropertyName("czy-zmienne")]
        public bool IsChangeable { get; set; }
    }
}
