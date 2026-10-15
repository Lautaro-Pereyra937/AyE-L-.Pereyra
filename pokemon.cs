using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class pokemon
    {
        public int Id { get; set; }
        public string? nombre { get; set; }

        [JsonPropertyName("tipo 1")]
        public string? tipo_1 { get; set; }

        [JsonPropertyName("tipo 2")]
        public string? tipo_2 { get; set; }
        public int hp { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }

        [JsonPropertyName("ataque especial")]
        public int ataque_especial { get; set; }

        [JsonPropertyName("defensa especial")]
        public int defensa_especial { get; set; }
        public int velocidad { get; set; }
        public int nivel { get; set; }

        public pokemon()
        {
        }
    }
}