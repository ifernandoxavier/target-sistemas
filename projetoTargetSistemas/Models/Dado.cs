using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace projetoTargetSistemas.Models
{
    public class Dado
    {
        [JsonProperty("dia")]
        public int Dia { get; set; }
        public decimal Valor { get; set; }
    }
}